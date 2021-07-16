using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using Commons.Xml.Relaxng;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShazamRestServices.Models;

namespace ShazamRestServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrackController : ControllerBase
    {
        private bool xmlValid = true;
        public List<TrackForValidate> Get()
        {
            return Startup.tracks;
        }

        [HttpPost("xml")]
        public void Post(XmlElement xmlTrack)
        {
            try
            {
                XmlDocument document = xmlTrack.OwnerDocument;
                document.AppendChild(xmlTrack);
                document.Schemas.Add("http://schemas.datacontract.org/2004/07/ShazamRestServices.Models", "trackNew.xsd");
                ValidationEventHandler validationHandler = new ValidationEventHandler(XmlValidation);

                document.Validate(XmlValidation);

                if (xmlValid)
                {
                    DataContractSerializer deserializer = new DataContractSerializer(typeof(TrackForValidate));
                    MemoryStream xmlStream = new MemoryStream();
                    document.Save(xmlStream);
                    xmlStream.Position = 0;
                    TrackForValidate track = (TrackForValidate)deserializer.ReadObject(xmlStream);
                    //Startup.tracks.Add(track);
                }
                else Response.StatusCode = StatusCodes.Status400BadRequest;
            }
            catch (Exception ex)
            {
                Response.StatusCode = StatusCodes.Status400BadRequest;
            }
        }

        [HttpPost("rng")]
        public void ValidateWithRng(XmlElement xmlTrack)
        {
            XmlDocument document = xmlTrack.OwnerDocument;
            document.AppendChild(xmlTrack);
            MemoryStream stream = new MemoryStream();
            document.Save(stream);

            stream.Flush();
            stream.Position = 0;

            XmlTextReader xmlReader = new XmlTextReader(stream);
            XmlReader xmlGrammar = new XmlTextReader("trackRng.rng");
            using (RelaxngValidatingReader reader = new RelaxngValidatingReader(xmlReader, xmlGrammar))
            {
                try
                {
                    while (!reader.EOF)
                        reader.Read();
                }
                catch (Exception ex)
                {
                    Response.StatusCode = StatusCodes.Status400BadRequest;
                }
            }
        }

        private void XmlValidation(object sender, ValidationEventArgs e)
        {
            xmlValid = false;
        }
    }
}