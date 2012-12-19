﻿using System;
using System.IO;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;

namespace EMailFogBugz
{
    public class FileSystemTemplateLoader : ITemplateLoader
    {
        public string LoadTemplate(string templateName, CultureInfo culture)
        {
            return File.ReadAllText(Path.Combine("MailTemplates", culture.ToString(), templateName + ".cshtml"));
        }
    }
}