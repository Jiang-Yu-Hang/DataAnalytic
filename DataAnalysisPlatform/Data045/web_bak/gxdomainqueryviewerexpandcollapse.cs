/*
               File: QueryViewerExpandCollapse
        Description: QueryViewerExpandCollapse
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:48:46.19
       Program type: Callable routine
          Main DBMS: SQL Server
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using GeneXus.Cryptography;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class gxdomainqueryviewerexpandcollapse
   {
      private static Hashtable domain = new Hashtable();
      private static Hashtable domainMap;
      static gxdomainqueryviewerexpandcollapse ()
      {
         domain["ExpandAllValues"] = "Expand all values";
         domain["CollapseAllValues"] = "Collapse all values";
         domain["ExpandSomeValues"] = "Expand some values";
      }

      public static string getDescription( IGxContext context ,
                                           String key )
      {
         string rtkey ;
         rtkey = StringUtil.Trim( (String)(key));
         return (string)domain[rtkey] ;
      }

      public static GxSimpleCollection<String> getValues( )
      {
         GxSimpleCollection<String> value = new GxSimpleCollection<String>();
         ArrayList aKeys = new ArrayList(domain.Keys);
         aKeys.Sort();
         foreach (String key in aKeys)
         {
            value.Add(key);
         }
         return value;
      }

      [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
      public static String getValue( string key )
      {
         if(domainMap == null)
         {
            domainMap = new Hashtable();
            domainMap["ExpandAllValues"] = "ExpandAllValues";
            domainMap["CollapseAllValues"] = "CollapseAllValues";
            domainMap["ExpandSomeValues"] = "ExpandSomeValues";
         }
         return (String)domainMap[key] ;
      }

   }

}
