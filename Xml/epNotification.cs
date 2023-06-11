using System;
using System.Xml.Linq;

namespace Parser_zakupki.gov.ru_.Xml
{
    public struct EpNotificationStruct
    {
        public int id;
        public string purchaseNumber;
        public DateTime publishDTInEIS;
        public string href;
        public string ETP_name;
        public string purchaseObjectInfo;
        public string maxPrice;
        public string fullName;
        public string postAddress;
        public PlacingWayEnum PlacingWay;

        public EpNotificationStruct(XDocument doc)
        {
            XNamespace ns9 = XNamespace.Get("http://zakupki.gov.ru/oos/EPtypes/1");
            XNamespace ns3 = XNamespace.Get("http://zakupki.gov.ru/oos/export/1");
            XNamespace ns2 = XNamespace.Get("http://zakupki.gov.ru/oos/base/1");

            string[] list = new string[6];
            list[0] = "epNotificationEF2020";
            list[1] = "epNotificationEZK2020";
            list[2] = "epNotificationEOK2020";
            list[3] = "epNotificationEZT2020";
            list[4] = "epNotificationCancel";
            list[5] = "epClarificationDoc";

            int selector;
            XElement main;
            for (int i = 0; i < list.Length; i++)
            {
                main = doc.Element(ns3 + "export").Element(ns3 + list[i]);
                if (main != null) { selector = i; goto Gets; }
            }
            throw new Exception("Такого типа нет в колекции");
        Gets:
            
            id = int.Parse(main.Element(ns9 + "id").Value);
            purchaseNumber = main.Element(ns9 + "commonInfo").Element(ns9 + "purchaseNumber").Value;

            XElement tmp = main.Element(ns9 + "commonInfo").Element(ns9 + "publishDTInEIS");
            if (tmp == null) tmp = main.Element(ns9 + "commonInfo").Element(ns9 + "docPublishDTInEIS");
            publishDTInEIS = DateTime.Parse(tmp.Value);

            href = main.Element(ns9 + "commonInfo").Element(ns9 + "href").Value;

            switch (selector)
            {
                case 3:
                    ETP_name = main.Element(ns9 + "commonInfo").Element(ns9 + "ETP").Element(ns2 + "name").Value;
                    purchaseObjectInfo = "Закупка у единственного поставщика";
                    maxPrice = main.Element(ns9 + "notificationInfo").Element(ns9 + "contractConditionsInfo")
                        .Element(ns9 + "maxPriceInfo").Element(ns9 + "maxPrice").Value;
                    fullName = main.Element(ns9 + "purchaseResponsibleInfo").Element(ns9 + "responsibleOrgInfo")
                        .Element(ns9 + "fullName").Value;
                    postAddress = main.Element(ns9 + "purchaseResponsibleInfo").Element(ns9 + "responsibleOrgInfo")
                       .Element(ns9 + "postAddress").Value;
                    break;
                case 4:
                    ETP_name = "";
                    purchaseObjectInfo = "(!) Отмена процедуры";
                    maxPrice = "";
                    fullName = "";
                    postAddress = "";                   
                    break;
                case 5:
                    ETP_name = "";
                    purchaseObjectInfo = "Ответ на запрос";
                    maxPrice = "";
                    fullName = "";
                    postAddress = "";
                    break;
                default:
                    ETP_name = main.Element(ns9 + "commonInfo").Element(ns9 + "ETP").Element(ns2 + "name").Value;
                    purchaseObjectInfo = main.Element(ns9 + "commonInfo").Element(ns9 + "purchaseObjectInfo").Value;
                    maxPrice = main.Element(ns9 + "notificationInfo").Element(ns9 + "contractConditionsInfo")
                        .Element(ns9 + "maxPriceInfo").Element(ns9 + "maxPrice").Value;
                    fullName = main.Element(ns9 + "purchaseResponsibleInfo").Element(ns9 + "responsibleOrgInfo")
                        .Element(ns9 + "fullName").Value;
                    postAddress = main.Element(ns9 + "purchaseResponsibleInfo").Element(ns9 + "responsibleOrgInfo")
                       .Element(ns9 + "postAddress").Value;
                    break;
            }
            PlacingWay = (PlacingWayEnum)selector;
        }

        public string[] ToArray()
        {
            string[] arr = new string[8];
            arr[0] = id.ToString();
            arr[1] = purchaseNumber;
            arr[2] = publishDTInEIS.Date.ToString("dd/MM/yyyy");
            arr[3] = ETP_name;
            arr[4] = purchaseObjectInfo;
            arr[5] = maxPrice;
            arr[6] = postAddress;
            arr[7] = Enum.GetName(typeof(PlacingWayEnum), PlacingWay);
            return arr;
        }

        public override string ToString()
        {
            return $"{id}Ъ{purchaseNumber}Ъ{publishDTInEIS.Date:dd/MM/yyyy}Ъ{ETP_name}Ъ{purchaseObjectInfo}Ъ{maxPrice}Ъ{postAddress}Ъ{Enum.GetName(typeof(PlacingWayEnum), PlacingWay)}";
        }

        public enum PlacingWayEnum
        {
            none = -1,
            ЭлектронныйАукцион = 0,
            ЗапросКотировок = 1,
            Конкурс = 2,
            ЗакупкаEдинственного = 3,
            Отмена = 4,
            Ответ_запрос = 5

        }
    }
}
