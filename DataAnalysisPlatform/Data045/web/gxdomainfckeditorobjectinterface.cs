/*
               File: FckEditorObjectInterface
        Description: FckEditorObjectInterface
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:17:55.77
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
   public class gxdomainfckeditorobjectinterface
   {
      private static Hashtable domain = new Hashtable();
      private static Hashtable domainMap;
      static gxdomainfckeditorobjectinterface ()
      {
         domain[(short)0] = "None";
         domain[(short)1] = "Dialog";
         domain[(short)2] = "Event";
      }

      public static string getDescription( IGxContext context ,
                                           short key )
      {
         return (string)domain[key] ;
      }

      public static GxSimpleCollection<short> getValues( )
      {
         GxSimpleCollection<short> value = new GxSimpleCollection<short>();
         ArrayList aKeys = new ArrayList(domain.Keys);
         aKeys.Sort();
         foreach (short key in aKeys)
         {
            value.Add(key);
         }
         return value;
      }

      [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
      public static short getValue( string key )
      {
         if(domainMap == null)
         {
            domainMap = new Hashtable();
            domainMap["None"] = (short)0;
            domainMap["Dialog"] = (short)1;
            domainMap["Event"] = (short)2;
         }
         return (short)domainMap[key] ;
      }

   }

}
