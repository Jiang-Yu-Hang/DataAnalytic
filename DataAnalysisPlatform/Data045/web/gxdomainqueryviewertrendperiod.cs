/*
               File: QueryViewerTrendPeriod
        Description: QueryViewerTrendPeriod
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:17:55.90
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
   public class gxdomainqueryviewertrendperiod
   {
      private static Hashtable domain = new Hashtable();
      private static Hashtable domainMap;
      static gxdomainqueryviewertrendperiod ()
      {
         domain["SinceTheBeginning"] = "Since the beginning";
         domain["LastYear"] = "Last year";
         domain["LastSemester"] = "Last semester";
         domain["LastQuarter"] = "Last quarter";
         domain["LastMonth"] = "Last month";
         domain["LastWeek"] = "Last week";
         domain["LastDay"] = "Last day";
         domain["LastHour"] = "Last hour";
         domain["LastMinute"] = "Last minute";
         domain["LastSecond"] = "Last second";
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
            domainMap["SinceTheBeginning"] = "SinceTheBeginning";
            domainMap["LastYear"] = "LastYear";
            domainMap["LastSemester"] = "LastSemester";
            domainMap["LastQuarter"] = "LastQuarter";
            domainMap["LastMonth"] = "LastMonth";
            domainMap["LastWeek"] = "LastWeek";
            domainMap["LastDay"] = "LastDay";
            domainMap["LastHour"] = "LastHour";
            domainMap["LastMinute"] = "LastMinute";
            domainMap["LastSecond"] = "LastSecond";
         }
         return (String)domainMap[key] ;
      }

   }

}
