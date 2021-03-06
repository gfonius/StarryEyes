﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.34014
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace StarryEyes.Globalization.Filters {
    using System;
    
    
    /// <summary>
    ///   ローカライズされた文字列などを検索するための、厳密に型指定されたリソース クラスです。
    /// </summary>
    // このクラスは StronglyTypedResourceBuilder クラスが ResGen
    // または Visual Studio のようなツールを使用して自動生成されました。
    // メンバーを追加または削除するには、.ResX ファイルを編集して、/str オプションと共に
    // ResGen を実行し直すか、または VS プロジェクトをビルドし直します。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class FilterObjectResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal FilterObjectResources() {
        }
        
        /// <summary>
        ///   このクラスで使用されているキャッシュされた ResourceManager インスタンスを返します。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("StarryEyes.Globalization.Filters.FilterObjectResources", typeof(FilterObjectResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   厳密に型指定されたこのリソース クラスを使用して、すべての検索リソースに対し、
        ///   現在のスレッドの CurrentUICulture プロパティをオーバーライドします。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Specified tab referencing self. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string FilterLocalTabIsRecursion {
            get {
                return ResourceManager.GetString("FilterLocalTabIsRecursion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Specified tab is not found: に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string FilterLocalTabNotFound {
            get {
                return ResourceManager.GetString("FilterLocalTabNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Receive failed from filter source: に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string FilterSourceBaseReceiveFailed {
            get {
                return ResourceManager.GetString("FilterSourceBaseReceiveFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Invalid argument is specified(source filter &quot;user&quot;) に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string FilterUserInvalidArgument {
            get {
                return ResourceManager.GetString("FilterUserInvalidArgument", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Invalid regular expression: に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string OperatorRegexInvalidPattern {
            get {
                return ResourceManager.GetString("OperatorRegexInvalidPattern", resourceCulture);
            }
        }
    }
}
