namespace ValidationAttributes.Utilities
{
    using System;
    using System.Linq;
    using System.Reflection;
    using Attributes;

    public static class Validator
    {
        public static bool IsValid(object obj)
        {
            Type type = obj.GetType();
            PropertyInfo[] properties = type.GetProperties()
                .Where(p => p.CustomAttributes
                .Any(ca => typeof(MyValidationAttribute)
                .IsAssignableFrom(ca.AttributeType))).ToArray();

            foreach (var prop in properties)
            {
                object[] customAttributes = prop.GetCustomAttributes()
                    .Where(ca => typeof(MyValidationAttribute)
                    .IsAssignableFrom(ca.GetType())).ToArray();
                object propValue = prop.GetValue(obj);

                foreach (var customAttribute in customAttributes)
                {
                    MethodInfo isValidMethod = customAttribute.GetType()
                        .GetMethods(BindingFlags.Instance | BindingFlags.Public)
                        .FirstOrDefault(m => m.Name == "IsValid");
                    if (isValidMethod == null) throw new InvalidOperationException("Method /IsValid/ not found!");

                    if(!(bool)isValidMethod.Invoke(customAttribute, new object[] { propValue })) return false;
                }
            }
            return true;
        }
    }
}
