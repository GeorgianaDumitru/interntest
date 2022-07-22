
using System.Xml;

XmlDocument xml = new XmlDocument();
xml.Load("https://rss.nytimes.com/services/xml/rss/nyt/World.xml");

XmlNodeList xnList = xml.SelectNodes("rss/channel/item");
foreach (XmlNode xn in xnList)
{
    try
    { 

    string title = xn["title"].InnerText;
    string creator = xn["dc:creator"].InnerText;
    string description = xn["description"].InnerText;
    string date = xn["pubDate"].InnerText;

    Console.WriteLine("Title:" + title);
    Console.WriteLine("Creator:" + creator);
    Console.WriteLine("Description:" + description);
    Console.WriteLine("Date:" + date);
    Console.WriteLine(" ");
}
    catch (NullReferenceException e)
{

}
}

