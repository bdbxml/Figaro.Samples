using System;
using Figaro;
using Figaro.Configuration.Factory;

namespace Figaro.Viewer
{
    /// <summary>
    /// The purpose of this class is to help developers get a quick-start introduction to using 
    /// the Figaro library in their application(s). For more information on how to use the library, it is 
    /// highly recommended that developers review the included help file (Figaro.chm) or online at 
    /// http://help.bdbxml.net .
    /// </summary>
    /// <seealso cref="http://bdbxml.net/blog"/>
    public class FigaroDataManager : IDisposable
    {

        /// <summary>
        /// Gets or sets the database manager.
        /// </summary>
        /// <seealso cref="http://help.bdbxml.net/html/514038c7-547b-476e-8bda-69428f315172.htm"/>
        public XmlManager Manager { get; }

        /// <summary>
        /// Gets the Figaro database.
        /// </summary>
        /// <seealso cref="http://help.bdbxml.net/html/ccfbe603-567a-4e3f-a616-123a787a8ac6.htm"/>
        public Container Database { get; }

        public FigaroDataManager()
        {
            Manager = ManagerFactory.Create("demoMgr");
            //http://help.bdbxml.net/html/b54e4294-4814-404f-a15f-32162b672260.htm
            Database = Manager.OpenContainer(ContainerConfigFactory.Create("demoMgr", "demo"));            
        }

        /// <summary>
        /// Inserts an XML record pulled from a URL.
        /// </summary>
        /// <param name="url">The URL to extract XML from.</param>
        /// <returns>The name of the record.</returns>
        public string InsertRecordFromUrl(string url)
        {
            var name = "record" + DateTime.Now.ToFileTimeUtc();
            var stm = Manager.CreateUrlInputStream(string.Empty, url);
            var doc = Manager.CreateDocument();
            doc.SetContentAsInputStream(stm);
            doc.Name = name;

            //add metadata to the record.
            doc.SetMetadata("http://schemas.bdbxml.net/metadata", "CreatedDate",
                new XmlValue(DateTime.Now.ToString()));
            Database.PutDocument(doc, Manager.CreateUpdateContext());
            return name;

        }

        /// <summary>
        /// Insert a System.Xml.XmlDocument into the database.
        /// </summary>
        /// <param name="doc">The document to insert.</param>
        /// <returns>The document name, for lookup purposes.</returns>
        public string InsertRecord(System.Xml.XmlDocument doc)
        {
            var name = "record" + DateTime.Now.ToFileTimeUtc();
            var xml = Manager.CreateDocument(doc);
            xml.Name = name;
            //add metadata to the record.
            xml.SetMetadata("http://schemas.bdbxml.net/metadata", "CreatedDate",
            new XmlValue(DateTime.Now.ToString()));
            Database.PutDocument(xml, Manager.CreateUpdateContext());
            return name;
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            Database.Dispose();
            Manager.Dispose();
        }
    }
}
