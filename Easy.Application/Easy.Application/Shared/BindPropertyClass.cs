using System.Reflection;

namespace Easy.ApplicationDesk.Shared
{
    public static class BindPropertyClass
    {
        public static string BindProperty(object property, string propertyName)
        {
            try
            {
                string retValue = "";
                if (propertyName.Contains("."))
                {
                    PropertyInfo[] arrayProperties;
                    string leftPropertyName;
                    leftPropertyName = propertyName.Substring(0, propertyName.IndexOf("."));
                    arrayProperties = property.GetType().GetProperties();
                    foreach (PropertyInfo propertyInfo in arrayProperties)
                    {
                        if (propertyInfo.Name == leftPropertyName)
                        {
                            retValue = BindProperty(
                              propertyInfo.GetValue(property, null),
                              propertyName.Substring(propertyName.IndexOf(".") + 1));
                            break;
                        }
                    }
                }
                else
                {
                    try
                    {
                        Type propertyType;
                        PropertyInfo propertyInfo;
                        propertyType = property.GetType();
                        propertyInfo = propertyType.GetProperty(propertyName);
                        retValue = propertyInfo.GetValue(property, null).ToString();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                }
                return retValue;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}