using System.Xml.Linq;


namespace Parser_zakupki.gov.ru_.Xml
{
    /// <summary>
    /// Устарел используеться до 2020 года
    /// </summary>
    public struct FcsNotificationEA44Struct
    {
        public string href;
        public string purchaseNumber;
        public string purchaseObjectInfo;
        public string placingWay_name;
        public string lot_maxPrice;
        public string attachments_attachment_url;

        public FcsNotificationEA44Struct(XDocument doc)
        {
            XNamespace export = XNamespace.Get("http://zakupki.gov.ru/oos/export/1");     
            XNamespace types = XNamespace.Get("http://zakupki.gov.ru/oos/types/1");
            XElement main;

            XElement EP = doc.Element(export + "export").Element(export + "fcsNotificationEP");
            XElement EF = doc.Element(export + "export").Element(export + "fcsNotificationEF");
            XElement ZK = doc.Element(export + "export").Element(export + "fcsNotificationZK");

            if (EF != null) { main = EF; }
            else if (EP != null) { main = EP; }
            else if (ZK != null) { main = ZK; }
            else { throw new System.Exception("Необходим тип."); }

            href = main.Element(types + "href").Value;
            purchaseNumber = main.Element(types + "purchaseNumber").Value;
            purchaseObjectInfo = main.Element(types + "purchaseObjectInfo").Value;
            placingWay_name = main.Element(types + "placingWay").Element(types + "name").Value;
            lot_maxPrice = main.Element(types + "lot").Element(types + "maxPrice").Value;

            XElement element = main.Element(types + "attachments").Element(types + "attachment");
            attachments_attachment_url = element == null  ? "": element.Element(types + "url").Value;

        }
    }
}
