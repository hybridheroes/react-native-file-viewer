using Microsoft.ReactNative;
using Microsoft.ReactNative.Managed;

namespace ReactNativeFileViewer
{
    public partial class ReactPackageProvider : IReactPackageProvider
    {
        public void CreatePackage(IReactPackageBuilder packageBuilder)
        {
            packageBuilder.AddReflectionReactPackageProvider<ReactPackageProvider>();
        }

        /// <summary>
        /// This method is implemented by the C# code generator
        /// </summary>
        partial void CreatePackageImplementation(IReactPackageBuilder packageBuilder);
    }
}
