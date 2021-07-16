using ShazamSoapService.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Web;
using System.Web.Services;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.XPath;

namespace ShazamSoapService
{
    /// <summary>
    /// Summary description for TrackSearchService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class TrackSearchService : System.Web.Services.WebService
    {
        private Tracks tracks;

        public TrackSearchService()
        {
            tracks = new Tracks();
            tracks.tracks = new List<TrackForValidate>();
            TrackForValidate track1 = new TrackForValidate
            {
                Title = "Neka pjesma",
                Subtitle = "Neki bend",
                Url = "nekiurl",
                Artists = new List<Artist> { new Artist { Id = "3434", Name = "Neki autor" } }
            };

            TrackForValidate track2 = new TrackForValidate
            {
                Title = "Neka pjesma2",
                Subtitle = "Neki bend2",
                Url = "nekiurl2",
                Artists = new List<Artist> { new Artist { Id = "34334", Name = "Neki autor2" } }
            };

            tracks.tracks.Add(track1);
            tracks.tracks.Add(track2);
        }

        [WebMethod]
        public TrackForValidate Search(string keyword)
        {
            //DataContractSerializer deserializer = new DataContractSerializer(typeof(TrackForValidate));
            XmlSerializer serializer = new XmlSerializer(tracks.GetType());
            MemoryStream stream = new MemoryStream();
            XmlWriter xmlWriter = XmlWriter.Create(stream);
            serializer.Serialize(xmlWriter, tracks);
            xmlWriter.Close();
            stream.Flush();
            stream.Position = 0;

            XPathDocument xpDoc = new XPathDocument(stream);
            XPathNavigator nav = xpDoc.CreateNavigator();
            string expression = "//TrackForValidate[Title='" + keyword + "']";
            XPathNodeIterator it = nav.Select(expression);

            if (it.MoveNext())
            {
                string value = it.Current.OuterXml;
                MemoryStream inputStream = new MemoryStream();
                StreamWriter streamWriter = new StreamWriter(inputStream);
                streamWriter.Write(value);
                streamWriter.Flush();
                inputStream.Position = 0;

                XmlSerializer deserializer = new XmlSerializer(typeof(TrackForValidate));
                TrackForValidate track = (TrackForValidate)deserializer.Deserialize(inputStream);

                return track;
            }

            return null;
        }

        [WebMethod]
        public int Proba(int a, int b)
        {
            return a + b;
        }
    }
}
