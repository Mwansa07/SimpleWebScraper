using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using SimpleWebScraper.Data;

namespace SimpleWebScraper.Builders
{
    public class ScrapeCriteriaBuilder
    {
        private string _data;
        private string _regex;
        private RegexOptions _regexOption;
        private List<ScrapeCriteriaPart> _parts;

        public ScrapeCriteriaBuilder()
        {
            SetDefault();
        }

        private void SetDefault()
        {
            throw new NotImplementedException();
        }
    }
}
