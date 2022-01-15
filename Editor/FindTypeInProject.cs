using UnityEditor;

namespace Kogane.Internal
{
    internal static class FindTypeInProject
    {
        private const string MENU_ITEM_NAME = "Assets/Find Type In Project";

        [MenuItem( MENU_ITEM_NAME, true )]
        private static bool CanFind()
        {
            return Selection.activeObject != null;
        }

        [MenuItem( MENU_ITEM_NAME )]
        private static void Find()
        {
            var asset = Selection.activeObject;
            var type  = asset.GetType();
            var name  = type.Name;

            ProjectBrowserInternal.SetSearch( $"t:{name}" );
        }
    }
}