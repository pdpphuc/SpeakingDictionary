using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace SpeakingDictionary
{
    public class DictionaryManager
    {
        #region properties
        private string filePath = "data.xml";

        private DictionaryItem item;
        public DictionaryItem Item { get => item; set => item = value; }
        #endregion

        #region methods
        public DictionaryManager()
        {
            item = (DictionaryItem)DeserializeFromXML(filePath);
            if(item == null)
            {
                Environment.Exit(0);
            }
        }

        public void LoadDataToComboBox(ComboBox combo)
        {
            combo.DataSource = item.Items;
            combo.DisplayMember = "Key";
        }

        public void Serialize()
        {
            SerializeToXML(Item, filePath);
        }
        private void SerializeToXML(object data, string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.Truncate, FileAccess.ReadWrite);
            XmlSerializer xml = new XmlSerializer(typeof(DictionaryItem));

            xml.Serialize(fs, data);
        }

        public object DeserializeFromXML(string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xml = new XmlSerializer(typeof(DictionaryItem));

            try
            {
                object obj = xml.Deserialize(fs);
                fs.Close();
                return obj;
            } 
            catch
            {
                MessageBox.Show("Lỗi file: data.xml!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        #endregion
    }
}
