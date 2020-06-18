using System.Net;
using System.Threading.Tasks;

namespace BaconIpsum
{
    public static class BaconIpsum
    {

        private static string BaseURL = "https://baconipsum.com/api";

        /// <summary>
        /// Gets some Quick Bacon with default configuration.
        /// </summary>
        /// <returns>JSON Formatted Bacon String.</returns>
        public static string GetBacon()
        {
            string url = BaseURL;
            string filler = GetFillerTypeString(Filler.FillerAndMeat);

            url += $"?{filler}";

            return GetBaconFromURL(url);
        }

        public static string GetBacon(Filler type)
        {
            string url = BaseURL;
            string filler = GetFillerTypeString(type);
            url += $"?{filler}";

            return GetBaconFromURL(url);
        }

        public static string GetBacon(Format format, Filler type)
        {
            string url = BaseURL;
            string filler = GetFillerTypeString(type);
            string stringformat = GetFormatString(format);

            url += $"?{filler}&{stringformat}";

            return GetBaconFromURL(url);
        }

        public static string GetBacon(int paragraphs)
        {
            string url = BaseURL;
            string filler = GetFillerTypeString(Filler.FillerAndMeat);
            string paras = GetParaString(paragraphs);

            url += $"?{filler}&{paras}";

            return GetBaconFromURL(url);
        }

        public static string GetBacon(Format format, int paragraphs)
        {
            string url = BaseURL;
            string filler = GetFillerTypeString(Filler.FillerAndMeat);
            string paras = GetParaString(paragraphs);
            string stringformat = GetFormatString(format);

            url += $"?{filler}&{paras}&{stringformat}";

            return GetBaconFromURL(url);
        }

        public static string GetBacon(Filler type, int paragraphs)
        {
            string url = BaseURL;
            string filler = GetFillerTypeString(type);
            string paras = GetParaString(paragraphs);

            url += $"?{filler}&{paras}";

            return GetBaconFromURL(url);
        }

        public static string GetBacon(Format format, Filler type, int paragraphs)
        {
            string url = BaseURL;
            string filler = GetFillerTypeString(type);
            string paras = GetParaString(paragraphs);
            string stringformat = GetFormatString(format);

            url += $"?{filler}&{paras}&{stringformat}";

            return GetBaconFromURL(url);
        }

        public static string GetBacon(bool startwithbacon)
        {
            string url = BaseURL;
            string filler = GetFillerTypeString(Filler.FillerAndMeat);
            string begin = GetStartWithLoremString(startwithbacon);

            url += $"?{filler}&{begin}";

            return GetBaconFromURL(url);
        }

        public static string GetBacon(Filler type, bool startwithbacon)
        {
            string url = BaseURL;
            string filler = GetFillerTypeString(type);
            string begin = GetStartWithLoremString(startwithbacon);

            url += $"?{filler}&{begin}";

            return GetBaconFromURL(url);
        }

        public static string GetBacon(int paragraphs, bool startwithbacon)
        {
            string url = BaseURL;
            string filler = GetFillerTypeString(Filler.FillerAndMeat);
            string paras = GetParaString(paragraphs);
            string begin = GetStartWithLoremString(startwithbacon);

            url += $"?{filler}&{paras}&{begin}";

            return GetBaconFromURL(url);
        }

        public static string GetBacon(Format format, Filler type, bool startwithbacon)
        {
            string url = BaseURL;
            string filler = GetFillerTypeString(type);
            string begin = GetStartWithLoremString(startwithbacon);
            string stringformat = GetFormatString(format);

            url += $"?{filler}&{begin}&{stringformat}";

            return GetBaconFromURL(url);
        }

        public static string GetBacon(Format format, int paragraphs, bool startwithbacon)
        {
            string url = BaseURL;
            string filler = GetFillerTypeString(Filler.FillerAndMeat);
            string paras = GetParaString(paragraphs);
            string begin = GetStartWithLoremString(startwithbacon);
            string stringformat = GetFormatString(format);

            url += $"?{filler}&{paras}&{begin}&{stringformat}";

            return GetBaconFromURL(url);
        }

        public static string GetBacon(Filler type, int paragraphs, bool startwithbacon)
        {
            string url = BaseURL;
            string filler = GetFillerTypeString(type);
            string paras = GetParaString(paragraphs);
            string begin = GetStartWithLoremString(startwithbacon);

            url += $"?{filler}&{paras}&{begin}";

            return GetBaconFromURL(url);
        }

        public static string GetBacon(Format format, Filler type, int paragraphs, bool startwithbacon)
        {
            string url = BaseURL;
            string filler = GetFillerTypeString(type);
            string paras = GetParaString(paragraphs);
            string begin = GetStartWithLoremString(startwithbacon);
            string stringformat = GetFormatString(format);

            url += $"?{filler}&{paras}&{begin}&{stringformat}";

            return GetBaconFromURL(url);
        }

        public static string GetBacon(Format format)
        {
            string url = BaseURL;
            string filler = GetFillerTypeString(Filler.FillerAndMeat);
            string stringformat = GetFormatString(format);

            url += $"?{filler}&{stringformat}";

            return GetBaconFromURL(url);
        }

        public static string GetBaconParagraph()
        {
            string url = BaseURL;
            string filler = GetFillerTypeString(Filler.FillerAndMeat);
            string paras = GetParaString(1);

            url += $"?{filler}&{paras}";

            return GetBaconFromURL(url);
        }

        public static string GetBaconParagraph(Filler type)
        {
            string url = BaseURL;
            string filler = GetFillerTypeString(type);
            string paras = GetParaString(1);

            url += $"?{filler}&{paras}";

            return GetBaconFromURL(url);
        }

        public static string GetBaconParagraph(Format format, Filler type)
        {
            string url = BaseURL;
            string filler = GetFillerTypeString(type);
            string paras = GetParaString(1);
            string stringformat = GetFormatString(format);

            url += $"?{filler}&{paras}&{stringformat}";

            return GetBaconFromURL(url);
        }

        public static string GetBaconParagraph(int sentences)
        {
            string url = BaseURL;
            string filler = GetFillerTypeString(Filler.FillerAndMeat);
            string sentencecount = GetSentencesString(sentences);

            url += $"?{filler}&{sentencecount}";

            return GetBaconFromURL(url);
        }

        public static string GetBaconParagraph(Format format, int sentences)
        {
            string url = BaseURL;
            string filler = GetFillerTypeString(Filler.FillerAndMeat);
            string sentencecount = GetSentencesString(sentences);
            string stringformat = GetFormatString(format);

            url += $"?{filler}&{sentencecount}&{stringformat}";

            return GetBaconFromURL(url);
        }

        public static string GetBaconParagraph(Filler type, int sentences)
        {
            string url = BaseURL;
            string filler = GetFillerTypeString(type);
            string sentencecount = GetSentencesString(sentences);

            url += $"?{filler}&{sentencecount}";

            return GetBaconFromURL(url);
        }

        public static string GetBaconParagraph(Format format, Filler type, int sentences)
        {
            string url = BaseURL;
            string filler = GetFillerTypeString(type);
            string sentencecount = GetSentencesString(sentences);
            string stringformat = GetFormatString(format);

            url += $"?{filler}&{sentencecount}&{stringformat}";

            return GetBaconFromURL(url);
        }

        public static string GetBaconParagraph(bool startwithbacon)
        {
            string url = BaseURL;
            string filler = GetFillerTypeString(Filler.FillerAndMeat);
            string paras = GetParaString(1);
            string begin = GetStartWithLoremString(startwithbacon);

            url += $"?{filler}&{paras}&{begin}";

            return GetBaconFromURL(url);
        }

        public static string GetBaconParagraph(Filler type, bool startwithbacon)
        {
            string url = BaseURL;
            string filler = GetFillerTypeString(type);
            string paras = GetParaString(1);
            string begin = GetStartWithLoremString(startwithbacon);

            url += $"?{filler}&{paras}&{begin}";

            return GetBaconFromURL(url);
        }

        public static string GetBaconParagraph(int sentences, bool startwithbacon)
        {
            string url = BaseURL;
            string filler = GetFillerTypeString(Filler.FillerAndMeat);
            string sentencecount = GetSentencesString(sentences);
            string begin = GetStartWithLoremString(startwithbacon);

            url += $"?{filler}&{sentencecount}&{begin}";

            return GetBaconFromURL(url);
        }

        public static string GetBaconParagraph(Format format, Filler type, bool startwithbacon)
        {
            string url = BaseURL;
            string filler = GetFillerTypeString(type);
            string paras = GetParaString(1);
            string begin = GetStartWithLoremString(startwithbacon);
            string stringformat = GetFormatString(format);

            url += $"?{filler}&{paras}&{begin}&{stringformat}";

            return GetBaconFromURL(url);
        }

        public static string GetBaconParagraph(Format format, int sentences, bool startwithbacon)
        {
            string url = BaseURL;
            string filler = GetFillerTypeString(Filler.FillerAndMeat);
            string sentencecount = GetSentencesString(sentences);
            string begin = GetStartWithLoremString(startwithbacon);
            string stringformat = GetFormatString(format);

            url += $"?{filler}&{sentencecount}&{begin}&{stringformat}";

            return GetBaconFromURL(url);
        }

        public static string GetBaconParagraph(Filler type, int sentences, bool startwithbacon)
        {
            string url = BaseURL;
            string filler = GetFillerTypeString(type);
            string sentencecount = GetSentencesString(sentences);
            string begin = GetStartWithLoremString(startwithbacon);

            url += $"?{filler}&{sentencecount}&{begin}";

            return GetBaconFromURL(url);
        }

        public static string GetBaconParagraph(Format format, Filler type, int sentences, bool startwithbacon)
        {
            string url = BaseURL;
            string filler = GetFillerTypeString(type);
            string sentencecount = GetSentencesString(sentences);
            string begin = GetStartWithLoremString(startwithbacon);
            string stringformat = GetFormatString(format);

            url += $"?{filler}&{sentencecount}&{begin}&{stringformat}";

            return GetBaconFromURL(url);
        }

        public static string GetBaconParagraph(Format format)
        {
            string url = BaseURL;
            string filler = GetFillerTypeString(Filler.FillerAndMeat);
            string paras = GetParaString(1);
            string stringformat = GetFormatString(format);

            url += $"?{filler}&{paras}&{stringformat}";

            return GetBaconFromURL(url);
        }

        private static string GetBaconFromURL(string url)
        {
            using (WebClient client = new WebClient())
            {
                var response = client.DownloadString(url);
                return response;
            }
        }

        #region Param Builders
        private static string GetFillerTypeString(Filler type)
        {
            switch (type)
            {
                case Filler.MeatOnly:
                    return "type=all-meat";
                case Filler.FillerAndMeat:
                default:
                    return "type=meat-and-filler";
            }
        }

        private static string GetParaString(int count)
        {
            return $"paras={count}";
        }
        private static string GetSentencesString(int sentences)
        {
            return $"sentences={sentences}";
        }

        private static string GetStartWithLoremString(bool startwithbacon)
        {
            if (startwithbacon)
                return $"start-with-lorem=1";

            return string.Empty;
        }

        private static string GetFormatString(Format format)
        {
            switch (format)
            {
                case Format.JSON:
                    return "format=json";
                case Format.TEXT:
                    return "format=text";
                case Format.HTML:
                    return "format=html";
            }

            return string.Empty;
        }
        #endregion



    }
}
