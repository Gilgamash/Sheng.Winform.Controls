//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:2.0.50727.4927
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sheng.Winform.Controls.Localisation {
    
    
    public interface ILanguage {
        
        /// <summary>
        ///   返回此类使用的缓存 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        global::System.Resources.ResourceManager ResourceManager {
            get;
        }
        
        /// <summary>
        ///   为使用此强类型资源类的所有资源查找
        ///   重写当前线程的 CurrentUICulture 属性。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        global::System.Globalization.CultureInfo Culture {
            get;
        }
        
        /// <summary>
        ///   查找类似 消息 的本地化字符串。
        /// </summary>
        string MessageBoxCaptiton_Message {
            get;
        }
        
        /// <summary>
        ///   查找类似 底部 的本地化字符串。
        /// </summary>
        string SEPaginationDataGridView_EnumNavigationLocation_Bottom {
            get;
        }
        
        /// <summary>
        ///   查找类似 顶部 的本地化字符串。
        /// </summary>
        string SEPaginationDataGridView_EnumNavigationLocation_Top {
            get;
        }
        
        /// <summary>
        ///   查找类似 更大 (48x48) 的本地化字符串。
        /// </summary>
        string SEToolStripImageSize_ExtraLarge {
            get;
        }
        
        /// <summary>
        ///   查找类似 大 (32x32) 的本地化字符串。
        /// </summary>
        string SEToolStripImageSize_Large {
            get;
        }
        
        /// <summary>
        ///   查找类似 中 (24x24) 的本地化字符串。
        /// </summary>
        string SEToolStripImageSize_Medium {
            get;
        }
        
        /// <summary>
        ///   查找类似 小 (16x16) 的本地化字符串。
        /// </summary>
        string SEToolStripImageSize_Small {
            get;
        }
        
        /// <summary>
        ///  Returns true if the current language is the default language.
        /// </summary>
        bool IsDefault {
            get;
        }
    }
}
