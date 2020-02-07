using UnityEngine;

namespace TinaXEditor.VFSKit
{
    internal static class VFSConfigDashboardI18N
    {
        internal static string WindowTitle
        {
            get
            {
                if (Application.systemLanguage == SystemLanguage.Chinese || Application.systemLanguage == SystemLanguage.ChineseSimplified)
                    return "VFS 面板";
                else
                    return "VFS Dashboard";
            }
        }

        internal static string EnableVFS
        {
            get
            {
                if (Application.systemLanguage == SystemLanguage.Chinese || Application.systemLanguage == SystemLanguage.ChineseSimplified)
                    return "启用VFS";
                else
                    return "Enable VFS";
            }
        }

        internal static string GlobalVFS_Ignore_ExtName
        {
            get
            {
                if (Application.systemLanguage == SystemLanguage.Chinese || Application.systemLanguage == SystemLanguage.ChineseSimplified)
                    return "忽略后缀名";
                else
                    return "Ignore extname";
            }
        }

        internal static string GlobalVFS_Ignore_PathItem
        {
            get
            {
                if (Application.systemLanguage == SystemLanguage.Chinese || Application.systemLanguage == SystemLanguage.ChineseSimplified)
                    return "忽略路径项目";
                else
                    return "Ignore path item";
            }
        }


        internal static string MsgBox_Common_Error
        {
            get
            {
                if (Application.systemLanguage == SystemLanguage.Chinese || Application.systemLanguage == SystemLanguage.ChineseSimplified)
                    return "不太对劲";
                else
                    return "Oops!";
            }
        }

        internal static string MsgBox_Common_Confirm
        {
            get
            {
                if (Application.systemLanguage == SystemLanguage.Chinese || Application.systemLanguage == SystemLanguage.ChineseSimplified)
                    return "好吧";
                else
                    return "Okey";
            }
        }

        internal static string MsgBox_Msg_CreateGroupNameIsNull
        {
            get
            {
                if (Application.systemLanguage == SystemLanguage.Chinese || Application.systemLanguage == SystemLanguage.ChineseSimplified)
                    return "资源组名称无效哦.";
                else
                    return "The asset group name you want to create is not valid.";
            }
        }

        internal static string MsgBox_Msg_CreateGroupNameHasExists
        {
            get
            {
                if (Application.systemLanguage == SystemLanguage.Chinese || Application.systemLanguage == SystemLanguage.ChineseSimplified)
                    return "要创建的资源组的名称\"{0}\"已经存在咯.";
                else
                    return "The name \"{0}\" of the assets group you want to create already exists.";
            }
        }

        internal static string Groups_Item_Null_Tips
        {
            get
            {
                if (Application.systemLanguage == SystemLanguage.Chinese || Application.systemLanguage == SystemLanguage.ChineseSimplified)
                    return "当前配置中没有任何资源组信息，请在窗口上方工具栏新建资源组。";
                else
                    return "There is no assets group information in the current configuration. Please create a new in the toolbar above the window.";
            }
        }


        internal static string Window_GroupConfig_Null_Tips
        {
            get
            {
                if (Application.systemLanguage == SystemLanguage.Chinese || Application.systemLanguage == SystemLanguage.ChineseSimplified)
                    return "选择一个资源组.";
                else
                    return "Select a group.";
            }
        }

        internal static string Window_GroupConfig_Title_GroupName
        {
            get
            {
                if (Application.systemLanguage == SystemLanguage.Chinese || Application.systemLanguage == SystemLanguage.ChineseSimplified)
                    return "资源组：";
                else
                    return "Asset Group: ";
            }
        }


        internal static string Window_GroupConfig_Title_FolderPaths
        {
            get
            {
                if (Application.systemLanguage == SystemLanguage.Chinese || Application.systemLanguage == SystemLanguage.ChineseSimplified)
                    return "白名单文件夹路径：";
                else
                    return "Whitelist folder paths: ";
            }
        }

        internal static string Window_GroupConfig_Title_AssetPaths
        {
            get
            {
                if (Application.systemLanguage == SystemLanguage.Chinese || Application.systemLanguage == SystemLanguage.ChineseSimplified)
                    return "白名单资源路径：";
                else
                    return "Whitelist asset paths: ";
            }
        }

        internal static string Window_GroupConfig_SelectFolder
        {
            get
            {
                if (Application.systemLanguage == SystemLanguage.Chinese || Application.systemLanguage == SystemLanguage.ChineseSimplified)
                    return "选择文件夹：";
                else
                    return "Select a folder: ";
            }
        }
        internal static string Window_GroupConfig_SelectAsset
        {
            get
            {
                if (Application.systemLanguage == SystemLanguage.Chinese || Application.systemLanguage == SystemLanguage.ChineseSimplified)
                    return "选择资源：";
                else
                    return "Select a asset: ";
            }
        }

        internal static string Window_GroupConfig_SelectAsset_Error_Select_Meta
        {
            get
            {
                if (Application.systemLanguage == SystemLanguage.Chinese || Application.systemLanguage == SystemLanguage.ChineseSimplified)
                    return "不可以选择\".meta\"后缀的文件加入VFS名单";
                else
                    return "Can not select a \".meta\" file to add VFS Asset list.";
            }
        }

        internal static string Window_Cannot_delete_internal_config_content
        {
            get
            {
                if (Application.systemLanguage == SystemLanguage.Chinese || Application.systemLanguage == SystemLanguage.ChineseSimplified)
                    return "由于VFS内部规则，不可以删除该项：{0}";
                else
                    return "The item \"{0}\"cannot be remove because of VFS internal rules.";
            }
        }

        internal static string Window_Cannot_delete_internal_config_title
        {
            get
            {
                if (Application.systemLanguage == SystemLanguage.Chinese || Application.systemLanguage == SystemLanguage.ChineseSimplified)
                    return "该项不可删除";
                else
                    return "Cannot remove item.";
            }
        }

        internal static string Window_Group_HandleMode
        {
            get
            {
                if (Application.systemLanguage == SystemLanguage.Chinese || Application.systemLanguage == SystemLanguage.ChineseSimplified)
                    return "资源组 处理模式：";
                else
                    return "Group handle type：";
            }
        }

        internal static string Menu_Build
        {
            get
            {
                if (Application.systemLanguage == SystemLanguage.Chinese || Application.systemLanguage == SystemLanguage.ChineseSimplified)
                    return "构建资源";
                else
                    return "Build";
            }
        }

        internal static string Menu_Build_BaseAsset
        {
            get
            {
                if (Application.systemLanguage == SystemLanguage.Chinese || Application.systemLanguage == SystemLanguage.ChineseSimplified)
                    return "完整资源包（母包）";
                else
                    return "Complete assets package";
            }
        }

    }
}