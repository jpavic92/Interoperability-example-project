using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using ShazamClient.Models;
using ShazamClient.Services;

namespace ShazamClient
{
    public partial class Form1 : Form
    {
        private const string ERROR_MESSAGE = "Error. Check again or try again later ...";
        private const string REQUEST_URI_STRING_XSD = "http://localhost:5000/api/Track/xml";
        private const string REQUEST_URI_STRING_RNG = "http://localhost:5000/api/Track/rng";
        private IList<Track> tracks;
        private IList<Artist> artists;

        public Form1()
        {
            InitializeComponent();
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            tracks = new List<Track>();
            artists = new List<Artist>();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string search = tbSearch.Text.Trim();
            if (!String.IsNullOrEmpty(search))
            {
                pbLoading.Show();
                await Task.Run(() => GetSearchResults(search));
                FillLbTracks();
                FillLbArtists();
                pbLoading.Hide();
            }
        }

        private void GetSearchResults(string search)
        {
            try
            {
                List<Models.Hit> trackHits = ShazamRestService.GetTracks(search).ToList();
                List<Hit> artistHits = ShazamRestService.GetArtists(search).ToList();
                tracks.Clear();
                artists.Clear();
                trackHits.ForEach(hit => tracks.Add(hit.Track));
                artistHits.ForEach(hit => artists.Add(hit.Artist));
            }
            catch (Exception)
            {
                MessageBox.Show("Error occured! Correct your input or try again");
            }

        }

        private void FillLbTracks()
        {
            lbTracks.Items.Clear();
            tracks.ToList().ForEach(track => lbTracks.Items.Add(track));
        }

        private void FillLbArtists()
        {
            lbArtists.Items.Clear();
            artists.ToList().ForEach(artist => lbArtists.Items.Add(artist));
        }


        private async void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string search = tbSearch.Text.Trim();
                if (!String.IsNullOrEmpty(search))
                {
                    pbLoading.Show();
                    await Task.Run(() => GetSearchResults(search));
                    FillLbTracks();
                    FillLbArtists();
                    pbLoading.Hide();
                }
            }
        }

        private void lbTracks_SelectedIndexChanged(object sender, EventArgs e)
        {
            pbImage.ImageLocation = ((Track)lbTracks.SelectedItem).Images.Background;
        }

        private void lbArtists_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(((Artist)lbArtists.SelectedItem).Avatar))
            {
                pbImage.ImageLocation = ((Artist)lbArtists.SelectedItem).Avatar;
            }
            else pbImage.Image = Properties.Resources.defualtImage;
        }

        private async void btnShowPlaylist_Click(object sender, EventArgs e)
        {
            if (lbArtists.SelectedItem != null)
            {
                pbLoading.Show();
                try
                {
                    String artistId = ((Artist)lbArtists.SelectedItem).Id;
                    PlaylistTrack[] playlist = await Task<PlaylistTrack[]>.Run(()
                        => ShazamRestService.GetPlaylist(artistId).Tracks.ToArray());
                    PlaylistForm playlistForm = new PlaylistForm(playlist);
                    playlistForm.Show();
                }
                catch (Exception)
                {

                    MessageBox.Show("Error occured! Correct your input or try again");
                }
                finally
                {
                    pbLoading.Hide();
                }
            }

            if (lbTracks.SelectedItem!= null)
            {
                XmlSerializer xsSubmit = new XmlSerializer(typeof(Track));
                Track track = (Track)lbTracks.SelectedItem;
                XmlDocument document = new XmlDocument();

                using (var sww = new StringWriter())
                {
                    using (XmlWriter writer = XmlWriter.Create(sww))
                    {
                        xsSubmit.Serialize(writer, track);
                        document.LoadXml(sww.ToString());
                        document.Save("track.xml");
                    }
                }
            }
        }

        private async void btnCheckTemp_Click(object sender, EventArgs e)
        {
            try
            {
                String stationName = tbStationName.Text.Trim();
                if (!String.IsNullOrEmpty(stationName))
                {
                    pbLoadingCityTemp.Show();
                    await Task.Run(() => GetTemperature(stationName));
                    pbLoadingCityTemp.Hide();
                }
            }
            catch (WebException we)
            {
                MessageBox.Show("Couldn't connect with the server. Try again later");
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong. Try again later");
            }
            finally
            {
                pbLoadingCityTemp.Hide();
            }
        }

        private void GetTemperature(string stationName)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("parameters.xml");

            doc.DocumentElement.ChildNodes[0].InnerText = "CityTemperature.getCityTemperature";
            doc.DocumentElement.ChildNodes[1].ChildNodes[0].ChildNodes[0].ChildNodes[0].InnerText = tbStationName.Text.Trim();

            MemoryStream xmlStream = new MemoryStream();
            doc.Save(xmlStream);

            byte[] data = Encoding.UTF8.GetBytes(Encoding.UTF8.GetString(xmlStream.ToArray()));

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://localhost:8080");
            request.Method = "POST";
            request.Accept = "application/xml";
            request.ContentType = "application/xml";

            Stream requestStream = request.GetRequestStream();
            requestStream.Write(data, 0, data.Length);
            requestStream.Close();

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                Stream responseStream = response.GetResponseStream();
                XmlDocument xmlResponse = new XmlDocument();
                xmlResponse.Load(responseStream);
                String result = xmlResponse.DocumentElement.ChildNodes[0].ChildNodes[0].ChildNodes[0].ChildNodes[0].InnerText;
                if (!String.IsNullOrEmpty(result))
                {
                    lblResult.Text = $"Temperature in {tbStationName.Text.Trim()}: {result}°C";
                }
                else lblResult.Text = "No data found";
            }
            else lblResult.Text = ERROR_MESSAGE;
        }

        private void Start()
        {

        }

        private void btnSaveTrack_Click(object sender, EventArgs e)
        {
            if (IsValid())
                SaveNewTrack();
        }

        private void SaveNewTrack()
        {
            TrackForValidate track = new TrackForValidate();
            track.Title = tbTitle.Text.Trim();
            track.Subtitle = tbSubtitle.Text.Trim();
            track.Url = tbUrl.Text.Trim();
            track.Artists = new List<Artist>();
            foreach (Artist artist in cbArtists.Items)
            {
                track.Artists.Add(artist);
            }

            DataContractSerializer serializer = new DataContractSerializer(typeof(TrackForValidate));
            MemoryStream stream = new MemoryStream();
            XmlWriter xmlWriter = XmlWriter.Create(stream);
            serializer.WriteObject(xmlWriter, track);
            xmlWriter.Close();

            byte[] dataToSend = Encoding.UTF8.GetBytes(Encoding.UTF8.GetString(stream.ToArray()));

            HttpWebRequest request;
            if (rbXsd.Checked) 
                request = (HttpWebRequest)WebRequest.Create(REQUEST_URI_STRING_XSD); 
            else request = (HttpWebRequest)WebRequest.Create(REQUEST_URI_STRING_RNG);

            request.Method = "POST";
            request.Accept = "application/xml";
            request.ContentType = "application/xml";

            Stream requestStream = request.GetRequestStream();
            requestStream.Write(dataToSend, 0, dataToSend.Length);
            requestStream.Close();

            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    lblValidationResult.Text = "Valid";
                }
                else lblValidationResult.Text = " Not valid";
            }
            catch (Exception)
            {
                lblValidationResult.Text = " Not valid";
            }
        }

        private bool IsValid()
        {
            List<TextBox> textBoxes = new List<TextBox>() { tbTitle, tbSubtitle, tbUrl};
            foreach (var tb in textBoxes)
            {
                if (String.IsNullOrEmpty(tb.Text.Trim()))
                {
                    return false;
                }
            }
            return true;
        }

        private void btnAddArtist_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbArtistName.Text.Trim()))
            {
                Artist artist = new Artist();
                artist.Name = tbArtistName.Text.Trim();
                artist.Id = cbArtists.Items.Count.ToString();
                cbArtists.Items.Add(artist);
                cbArtists.SelectedIndex = 0;
                tbArtistName.Text = "";
            }
        }

        private void btnSearchEntity_Click(object sender, EventArgs e)
        {
            lbSearchResults.Items.Clear();
            if (!String.IsNullOrEmpty(tbKeyword.Text.Trim()))
            {
                lblKeywordError.Visible = false;
                SoapService2.TrackSearchServiceSoapClient service =
                new SoapService2.TrackSearchServiceSoapClient();

                SoapService2.TrackForValidate searchResult = service.SearchAsync(tbKeyword.Text.Trim()).Result.Body.SearchResult;

                if (searchResult != null)
                {
                    TrackForValidate track = new TrackForValidate();
                    track.Artists = new List<Artist>();
                    track.Title = searchResult.Title;
                    track.Subtitle = searchResult.Subtitle;
                    track.Url = searchResult.Url;
                    List<SoapService2.Artist> list = searchResult.Artists.ToList();
                    foreach (SoapService2.Artist item in list)
                    {
                        Artist artist = new Artist();
                        artist.Adamid = item.Adamid;
                        artist.Id = item.Id;
                        artist.Name = item.Name;
                        track.Artists.Add(artist);
                    }

                    lbSearchResults.Items.Add(track);
                }
                else MessageBox.Show("No results found ...");
            }
            else
            {
                lblSearchResults.Text = "Enter a keyword to search";
                lblKeywordError.Visible = true;
            }
        }
    }
}
