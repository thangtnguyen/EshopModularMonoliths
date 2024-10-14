namespace Catalog.Data.Seed
{
    public static class InitialData
    {
        public static IEnumerable<Product> Products =>
            new List<Product> {
                Product.Create(new Guid("5F2BB9F9-4B35-40D0-9E1E-55D19564CCB5"), "IPhoneX", ["category1"], "Long description", "imageFile", 500),
                Product.Create(new Guid("40C09555-2D6D-4573-B1AD-F17857DA4659"), "Samsung 10", ["category1"], "Long description", "imageFile", 400),
                Product.Create(new Guid("2E09495E-5170-4C29-9811-3F25D426BCA2"), "Huawei Plus", ["category2"], "Long description", "imageFile", 650),
                Product.Create(new Guid("7978EE9A-B0D9-492F-8421-CADF8916786D"), "Xiaomi Mi", ["category2"], "Long description", "imageFile", 450)
            };
    }
}
