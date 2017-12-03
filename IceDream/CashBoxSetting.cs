using System;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace IceDream
{
    public partial class CashBoxSetting : Form
    {
        //*****************************************************************************************************
        XmlDocument xDoc = new XmlDocument();
        public static Thread thOpenMM;
        public static bool infoNoChangedd = true;
        string old_tbIceCream_S, old_tbCup_S, old_tbCrepe_S, old_tbBelgianWaffles_S, old_tbPancake_S,
            old_tbFluff_S, old_tbChocolate_S, old_tbCandies_S, old_tbFruits_S, old_tbNuts_S, old_tbEspresso_S,
            old_tbCappuccino_S, old_tbInstantCoffee_S, old_tbTea_S, old_tbChocolateMilk_S, old_tbCokaCola_S,
            old_tbSprite_S, old_tbOrange_S, old_tbNestea_S, old_tbWater_S;
        private DateTime clock = DateTime.Now;          //להצגת שעון במסך
        //********************************************************************************************************

        public CashBoxSetting()
        {
            InitializeComponent();
            lblClock.Text = clock.ToString();
        }
        private void back_btn_Click(object sender, EventArgs e)              //כפתור חזרה
        {
            if (old_tbIceCream_S != tbIceCream_S.Text || old_tbCup_S != tbCup_S.Text || old_tbCrepe_S != tbCrepe_S.Text ||
            old_tbBelgianWaffles_S != tbBelgianWaffles_S.Text || old_tbPancake_S != tbPancake_S.Text || old_tbFluff_S != tbFluff_S.Text ||
            old_tbChocolate_S != tbChocolate_S.Text || old_tbCandies_S != tbCandies_S.Text || old_tbFruits_S != tbFruits_S.Text ||
            old_tbNuts_S != tbNuts_S.Text || old_tbEspresso_S != tbEspresso_S.Text || old_tbCappuccino_S != tbCappuccino_S.Text ||
            old_tbInstantCoffee_S != tbInstantCoffee_S.Text || old_tbTea_S != tbTea_S.Text || old_tbChocolateMilk_S != tbChocolateMilk_S.Text ||
            old_tbCokaCola_S != tbCokaCola_S.Text || old_tbSprite_S != tbSprite_S.Text || old_tbOrange_S != tbOrange_S.Text ||
            old_tbNestea_S != tbNestea_S.Text || old_tbWater_S != tbWater_S.Text)
            {
                DialogResult dlgresult = MessageBox.Show("האם אתה בטוח שברצונך לצאת? הנתונים לא יישמרו", "הודעת אזהרה",
                 MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dlgresult == DialogResult.OK)
                {
                    this.Close();
                    thOpenMM = new Thread(MainMenuForm);
                    thOpenMM.SetApartmentState(ApartmentState.STA);
                    thOpenMM.Start();
                }
            }
            else
            {
                this.Close();
                thOpenMM = new Thread(MainMenuForm);
                thOpenMM.SetApartmentState(ApartmentState.STA);
                thOpenMM.Start();
            }
        }
        private void CashBoxSetting_Load(object sender, EventArgs e)
        {
            CashBoxSettingLoad();
        }
        private void CashBoxSettingLoad()
        {
            IceDream.MainMenuForm.saveClicked = false;
            xDoc.Load(IceDream.MainMenuForm.path + "\\DatabasePrice.xml");
            old_tbIceCream_S = tbIceCream_S.Text = xDoc.SelectSingleNode("allProducts/IceCream/Price").InnerText;
            old_tbCup_S = tbCup_S.Text = xDoc.SelectSingleNode("allProducts/Cups/Price").InnerText;
            old_tbCrepe_S = tbCrepe_S.Text = xDoc.SelectSingleNode("allProducts/Crepe/Price").InnerText;
            old_tbBelgianWaffles_S = tbBelgianWaffles_S.Text = xDoc.SelectSingleNode("allProducts/BelgianWaffles/Price").InnerText;
            old_tbPancake_S = tbPancake_S.Text = xDoc.SelectSingleNode("allProducts/Pancake/Price").InnerText;
            old_tbFluff_S = tbFluff_S.Text = xDoc.SelectSingleNode("allProducts/Fluff/Price").InnerText;
            old_tbChocolate_S = tbChocolate_S.Text = xDoc.SelectSingleNode("allProducts/Chocolate/Price").InnerText;
            old_tbCandies_S = tbCandies_S.Text = xDoc.SelectSingleNode("allProducts/Candies/Price").InnerText;
            old_tbFruits_S = tbFruits_S.Text = xDoc.SelectSingleNode("allProducts/Fruits/Price").InnerText;
            old_tbNuts_S = tbNuts_S.Text = xDoc.SelectSingleNode("allProducts/Nuts/Price").InnerText;
            old_tbEspresso_S = tbEspresso_S.Text = xDoc.SelectSingleNode("allProducts/Espresso/Price").InnerText;
            old_tbCappuccino_S = tbCappuccino_S.Text = xDoc.SelectSingleNode("allProducts/Cappuccino/Price").InnerText;
            old_tbInstantCoffee_S = tbInstantCoffee_S.Text = xDoc.SelectSingleNode("allProducts/InstantCoffee/Price").InnerText;
            old_tbTea_S = tbTea_S.Text = xDoc.SelectSingleNode("allProducts/Tea/Price").InnerText;
            old_tbChocolateMilk_S = tbChocolateMilk_S.Text = xDoc.SelectSingleNode("allProducts/ChocolateMilk/Price").InnerText;
            old_tbCokaCola_S = tbCokaCola_S.Text = xDoc.SelectSingleNode("allProducts/CocaCola/Price").InnerText;
            old_tbSprite_S = tbSprite_S.Text = xDoc.SelectSingleNode("allProducts/Sprite/Price").InnerText;
            old_tbOrange_S = tbOrange_S.Text = xDoc.SelectSingleNode("allProducts/Orange/Price").InnerText;
            old_tbNestea_S = tbNestea_S.Text = xDoc.SelectSingleNode("allProducts/Nestea/Price").InnerText;
            old_tbWater_S = tbWater_S.Text = xDoc.SelectSingleNode("allProducts/Water/Price").InnerText;
        }                           //טעינת הנתונים מהקובץ
        private void updateOld()
        {
            old_tbIceCream_S = tbIceCream_S.Text;
            old_tbCup_S = tbCup_S.Text;
            old_tbCrepe_S = tbCrepe_S.Text;
            old_tbBelgianWaffles_S = tbBelgianWaffles_S.Text;
            old_tbPancake_S = tbPancake_S.Text;
            old_tbFluff_S = tbFluff_S.Text;
            old_tbChocolate_S = tbChocolate_S.Text;
            old_tbCandies_S = tbCandies_S.Text;
            old_tbFruits_S = tbFruits_S.Text;
            old_tbNuts_S = tbNuts_S.Text;
            old_tbEspresso_S = tbEspresso_S.Text;
            old_tbCappuccino_S = tbCappuccino_S.Text;
            old_tbInstantCoffee_S = tbInstantCoffee_S.Text;
            old_tbTea_S = tbTea_S.Text;
            old_tbChocolateMilk_S = tbChocolateMilk_S.Text;
            old_tbCokaCola_S = tbCokaCola_S.Text;
            old_tbSprite_S = tbSprite_S.Text;
            old_tbOrange_S = tbOrange_S.Text;
            old_tbNestea_S = tbNestea_S.Text;
            old_tbWater_S = tbWater_S.Text;
        }
        private void save_btn_Click(object sender, EventArgs e)
        {
            IceDream.MainMenuForm.saveClicked = true;
            updateOld();
            int parsedValue;
            if (!int.TryParse(tbIceCream_S.Text, out parsedValue) ||
                !int.TryParse(tbCup_S.Text, out parsedValue) ||
                !int.TryParse(tbBelgianWaffles_S.Text, out parsedValue) ||
                !int.TryParse(tbCandies_S.Text, out parsedValue) ||
                !int.TryParse(tbCappuccino_S.Text, out parsedValue) ||
                !int.TryParse(tbChocolateMilk_S.Text, out parsedValue) ||
                !int.TryParse(tbChocolate_S.Text, out parsedValue) ||
                !int.TryParse(tbCokaCola_S.Text, out parsedValue) ||
                !int.TryParse(tbCrepe_S.Text, out parsedValue) ||
                !int.TryParse(tbEspresso_S.Text, out parsedValue) ||
                !int.TryParse(tbFluff_S.Text, out parsedValue) ||
                !int.TryParse(tbFruits_S.Text, out parsedValue) ||
                !int.TryParse(tbInstantCoffee_S.Text, out parsedValue) ||
                !int.TryParse(tbNestea_S.Text, out parsedValue) ||
                !int.TryParse(tbNuts_S.Text, out parsedValue) ||
                !int.TryParse(tbOrange_S.Text, out parsedValue) ||
                !int.TryParse(tbPancake_S.Text, out parsedValue) ||
                !int.TryParse(tbSprite_S.Text, out parsedValue) ||
                !int.TryParse(tbTea_S.Text, out parsedValue) ||
                !int.TryParse(tbWater_S.Text, out parsedValue) ||
                Int32.Parse(tbBelgianWaffles_S.Text) < 0 || Int32.Parse(tbCandies_S.Text) < 0 ||
                Int32.Parse(tbCappuccino_S.Text) < 0 || Int32.Parse(tbChocolateMilk_S.Text) < 0 ||
                Int32.Parse(tbChocolate_S.Text) < 0 || Int32.Parse(tbCokaCola_S.Text) < 0 ||
                Int32.Parse(tbCrepe_S.Text) < 0 || Int32.Parse(tbCup_S.Text) < 0 ||
                Int32.Parse(tbEspresso_S.Text) < 0 || Int32.Parse(tbFluff_S.Text) < 0 ||
                Int32.Parse(tbFruits_S.Text) < 0 || Int32.Parse(tbIceCream_S.Text) < 0 ||
                Int32.Parse(tbInstantCoffee_S.Text) < 0 || Int32.Parse(tbNestea_S.Text) < 0 ||
                Int32.Parse(tbNuts_S.Text) < 0 || Int32.Parse(tbOrange_S.Text) < 0 ||
                Int32.Parse(tbPancake_S.Text) < 0 || Int32.Parse(tbSprite_S.Text) < 0 ||
                Int32.Parse(tbTea_S.Text) < 0 || Int32.Parse(tbWater_S.Text) < 0)
            {
                MessageBox.Show("\t\t,שים לב\n" + ",באחד או יותר מהמוצרים הזנת ערך לא חוקי\n" + "\tיש להזין רק מספרים בין 0-9", "הודעה למשתמש", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            XmlTextWriter xWriterPrice = new XmlTextWriter(IceDream.MainMenuForm.path + "\\DatabasePrice.xml", Encoding.UTF8);

            #region WriteToXml
            xWriterPrice.Formatting = Formatting.Indented;
            xWriterPrice.WriteStartElement("allProducts");
            xWriterPrice.WriteStartElement("IceCream");
            xWriterPrice.WriteStartElement("Price");
            xWriterPrice.WriteString(tbIceCream_S.Text);
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteStartElement("Cups");
            xWriterPrice.WriteStartElement("Price");
            xWriterPrice.WriteString(tbCup_S.Text);
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteStartElement("Crepe");
            xWriterPrice.WriteStartElement("Price");
            xWriterPrice.WriteString(tbCrepe_S.Text);
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteStartElement("BelgianWaffles");
            xWriterPrice.WriteStartElement("Price");
            xWriterPrice.WriteString(tbBelgianWaffles_S.Text);
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteStartElement("Pancake");
            xWriterPrice.WriteStartElement("Price");
            xWriterPrice.WriteString(tbPancake_S.Text);
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteStartElement("Fluff");
            xWriterPrice.WriteStartElement("Price");
            xWriterPrice.WriteString(tbFluff_S.Text);
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteStartElement("Chocolate");
            xWriterPrice.WriteStartElement("Price");
            xWriterPrice.WriteString(tbChocolate_S.Text);
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteStartElement("Candies");
            xWriterPrice.WriteStartElement("Price");
            xWriterPrice.WriteString(tbCandies_S.Text);
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteStartElement("Fruits");
            xWriterPrice.WriteStartElement("Price");
            xWriterPrice.WriteString(tbFruits_S.Text);
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteStartElement("Nuts");
            xWriterPrice.WriteStartElement("Price");
            xWriterPrice.WriteString(tbNuts_S.Text);
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteStartElement("Espresso");
            xWriterPrice.WriteStartElement("Price");
            xWriterPrice.WriteString(tbEspresso_S.Text);
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteStartElement("Cappuccino");
            xWriterPrice.WriteStartElement("Price");
            xWriterPrice.WriteString(tbCappuccino_S.Text);
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteStartElement("InstantCoffee");
            xWriterPrice.WriteStartElement("Price");
            xWriterPrice.WriteString(tbInstantCoffee_S.Text);
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteStartElement("Tea");
            xWriterPrice.WriteStartElement("Price");
            xWriterPrice.WriteString(tbTea_S.Text);
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteStartElement("ChocolateMilk");
            xWriterPrice.WriteStartElement("Price");
            xWriterPrice.WriteString(tbChocolateMilk_S.Text);
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteStartElement("CocaCola");
            xWriterPrice.WriteStartElement("Price");
            xWriterPrice.WriteString(tbCokaCola_S.Text);
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteStartElement("Sprite");
            xWriterPrice.WriteStartElement("Price");
            xWriterPrice.WriteString(tbSprite_S.Text);
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteStartElement("Orange");
            xWriterPrice.WriteStartElement("Price");
            xWriterPrice.WriteString(tbOrange_S.Text);
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteStartElement("Nestea");
            xWriterPrice.WriteStartElement("Price");
            xWriterPrice.WriteString(tbNestea_S.Text);
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteStartElement("Water");
            xWriterPrice.WriteStartElement("Price");
            xWriterPrice.WriteString(tbWater_S.Text);
            xWriterPrice.WriteEndElement();
            xWriterPrice.Close();
            #endregion
            Thread.Sleep(1000);
        }      //שמירת הגדרות מחירי הקופה בקובץ xml
        private void MainMenuForm()
        {
            Application.Run(new MainMenuForm());
        }
        private void timer_Clock_Tick(object sender, EventArgs e)       //טיימר להצגת שעון רץ
        {
            clock = DateTime.Now;
            lblClock.Text = clock.ToString();
        }
    }
}
