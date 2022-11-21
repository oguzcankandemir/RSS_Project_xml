using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using CodeHollow.FeedReader;


namespace RSS_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Readasync-Asekron =>await kulllandım = tamamı okunana kadar bekliyorum =okuma bitince devam et
        async void Get_RSS()
        {
           

            string feedUrl = lbl_Link_News.Text;
                             //RSS okuyorum
            var feed = await FeedReader.ReadAsync(feedUrl);
            var xDocument = XDocument.Parse(feed.OriginalDocument);//XML Belgesi
            var xNamespace = xDocument.Root.GetDefaultNamespace();// XNamespace Bunun varsayılan kısmını aldım XElement .
            int index = 0;
            foreach (var item in feed.Items)
            {
                // link label den url yi alıyorum => Asenkron okudum = parse ettim =>namespace aldım = foreach döngüsü ile dönüyorum
                var baseFeedItem = item.SpecificItem;
                string thumbnail = null;
                //Koleksiyonda belirtilen dizindeki öğeyi döndürdüm                                   //null
                if (baseFeedItem.Element.Descendants().Any(x => x.Name.LocalName == xNamespace + "thumbnail"))// RSS=>yazı ve görsellerin urlsi ni aldım
                {                                                
                    thumbnail = baseFeedItem.Element.Descendants().First(x => x.Name.LocalName == xNamespace + "thumbnail").Attribute("url").Value;
                }
                //0 var ++ index
                index++;
                // tek tek ekrana çekiyorum 
                txt_explain.Text = thumbnail;
                pic_image.ImageLocation = thumbnail;
                txt_explain.Text = (item.Description);
                link_lbl_url.Text = item.Link;
            
               
               
            }
        }
      
        private void RSS_Load(object sender, EventArgs e)
        {

           //DLl
            Assembly asm = Assembly.GetExecutingAssembly();
            Type[] types = asm.GetTypes();// Type değerini al
            foreach (Type type in types)
            {
                if (type.BaseType != null && type.BaseType.Name == "News")
                {
                    News news = (News)Activator.CreateInstance(type);
                    comboBox1.Items.Add(news);
                }

            }
        }


        private void Get_button2_Click(object sender, EventArgs e)
        {
            //combobox tan seçtiğim ıtem Linklabel e yansıttım
            News nv = (News)comboBox1.SelectedItem;
            if (nv.GetType().GetInterface("IFeatures") != null)
            {
                IFeatures features = (IFeatures)nv;
                lbl_Link_News.Text = features.Features();
            }
        }

        //tek tık Haberler gelsin
        private void Haber_linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Get_RSS();
        }
    }
}
