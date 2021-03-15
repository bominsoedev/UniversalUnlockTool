namespace UniversalUnlockTool
{
    public static class boot
    {
        public static string Scatterfile
        {
            get;
            set;
        }

        public static string Da { get; set; }
        public static string Auth { get; set; }

        public static string Preloader
        {
            get;
            set;
        }

        public static string Connection
        {
            get;
            set;
        }

        public static string Config_json
        {
            get;
            set;
        }

        public static string Payload
        {
            get;
            set;
        }

        public static bool CheckAuth(string scatter)
        {
            bool flag = false;
            bool result;
            try
            {
                if (mtkxml.isSupport(scatter))
                {
                    if (mtkxml.CPU.ToLower() == "mt6572")
                    {
                        flag = true;
                    }
                    if (mtkxml.CPU.ToLower() == "mt6735")
                    {
                        flag = true;
                    }
                    else if (mtkxml.CPU.ToLower() == "mt6737")
                    {
                        flag = true;
                    }
                    else if (mtkxml.CPU.ToLower() == "mt6739")
                    {
                        flag = true;
                    }
                    else if (mtkxml.CPU.ToLower() == "mt6750")
                    {
                        flag = true;
                    }
                    else if (mtkxml.CPU.ToLower() == "mt6765")
                    {
                        flag = true;
                    }
                    else if (mtkxml.CPU.ToLower() == "mt6768")
                    {
                        flag = true;
                    }
                    else if (mtkxml.CPU.ToLower() == "mt6771")
                    {
                        flag = true;
                    }
                    else if (mtkxml.CPU.ToLower() == "mt6785")
                    {
                        flag = true;
                    }
                    else if (mtkxml.CPU.ToLower() == "mt8127")
                    {
                        flag = true;
                    }
                    else if (mtkxml.CPU.ToLower() == "mt8163")
                    {
                        flag = true;
                    }
                    else if (mtkxml.CPU.ToLower() == "mt8173")
                    {
                        flag = true;
                    }
                    else if (mtkxml.CPU.ToLower() == "mt8695")
                    {
                        flag = true;
                    }
                }
                result = flag;
            }
            catch
            {
                result = false;
            }
            return result;
        }
    }
}