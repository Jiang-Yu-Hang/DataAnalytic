/*
               File: QueryViewerXAxisLabels
        Description: QueryViewerXAxisLabels
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:48:46.28
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
   public class gxdomainqueryviewerxaxislabels
   {
      private static Hashtable domain = new Hashtable();
      private static Hashtable domainMap;
      static gxdomainqueryviewerxaxislabels ()
      {
         domain["Horizontally"] = "Horizontally";
         domain["Rotated30"] = "Rotated 30o";
         domain["Rotated45"] = "Rotated 45o";
         domain["Rotated60"] = "Rotated 60o";
         domain["Vertically"] = "Vertically";
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
            domainMap["Horizontally"] = "Horizontally";
            domainMap["Rotated30"] = "Rotated30";
            domainMap["Rotated45"] = "Rotated45";
            domainMap["Rotated60"] = "Rotated60";
            domainMap["Vertically"] = "Vertically";
         }
         return (String)domainMap[key] ;
      }

   }

}
