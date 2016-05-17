using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace RimworldModManager.DataObjects
{
    class Dependency
    {
        public string m_DiskNme;
        public string m_Description;
        public string m_Url;

        public static Dependency CreateDependency(XmlNode _CurrentNode)
        {
            Dependency _Dependency = new Dependency();

            var _XmlDiskName = _CurrentNode.SelectSingleNode("DiskName");
            if (_XmlDiskName != null)
            {
                _Dependency.m_DiskNme = _XmlDiskName.InnerText;
            }

            var _XmlDescription = _CurrentNode.SelectSingleNode("Description");
            if (_XmlDescription != null)
            {
                _Dependency.m_Description = _XmlDescription.InnerText;
            }

            var _XmlUrl = _CurrentNode.SelectSingleNode("Url");
            if (_XmlUrl != null)
            {
                _Dependency.m_Url = _XmlUrl.InnerText;
            }

            return _Dependency;
        }



    }
}
