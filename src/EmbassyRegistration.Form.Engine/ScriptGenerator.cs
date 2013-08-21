using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using EmbassyRegistration.Form.Engine.Models;

namespace EmbassyRegistration.Form.Engine
{
    public class ScriptGenerator
    {
        private readonly string templatePath;
        private readonly string generatedTemplatesPath;

        public ScriptGenerator(string templatePath, string generatedTemplatesPath)
        {
            this.templatePath = templatePath;
            this.generatedTemplatesPath = generatedTemplatesPath;
        }

        public void Generate(ApplicationModel model)
        {
            var doc = LoadTemplate();

            var actionRows = doc.Descendants().Where(e => e.Name.LocalName == "tr").ToList();

            GeneratePersonalInfo(actionRows, model.PersonalInfo);

            SaveTemplate(doc, model);
        }

        private XDocument LoadTemplate()
        {
            var doc = XDocument.Load(templatePath);

            return doc;
        }

        private void SaveTemplate(XDocument document, ApplicationModel model)
        {
            var path = GenerateFileName(model);

            document.Save(path);
        }

        private void GeneratePersonalInfo(List<XElement> actionRows, PersonalInfo personalInfo)
        {
            //set last name
            SetValue(actionRows[1], personalInfo.LastName);
            SetValue(actionRows[2], personalInfo.LastName);
            //set first name
            SetValue(actionRows[3], personalInfo.FirstName);
            //set date of birth
            SetValue(actionRows[4], personalInfo.DateOfBirth.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
            //set birth place
            SetValue(actionRows[5], personalInfo.BithPlace);
        }

        private void SetValue(XElement row, string value)
        {
            row.Elements().Last().Value = value;
        }

        private string GenerateFileName(ApplicationModel model)
        {
            string subFolderName = string.Format("{0}_{1}", model.PersonalInfo.LastName, model.PersonalInfo.FirstName);
            string subfolderPath = Path.Combine(generatedTemplatesPath, subFolderName);
            VerifyDirectory(subfolderPath);
            string fileName = string.Format("{0:MM_dd_yyyy_hh_mm_ss}.xhtml", DateTime.Now);

            return Path.Combine(subfolderPath, fileName);
        }

        private void VerifyDirectory(string path)
        {
            var directoryInfo = new DirectoryInfo(path);
            if (!directoryInfo.Exists)
            {
                directoryInfo.Create();
            }
        }
    }
}
