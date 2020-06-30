/*
               File: DM_ApproveStatus
        Description: DM_ApproveStatus
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:48:45.98
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
   public class gxdomaindm_approvestatus
   {
      private static Hashtable domain = new Hashtable();
      private static Hashtable domainMap;
      static gxdomaindm_approvestatus ()
      {
         domain[(short)1] = "录入中";
         domain[(short)2] = "待初审";
         domain[(short)3] = "初审不通过";
         domain[(short)4] = "待复审";
         domain[(short)5] = "复审不通过";
         domain[(short)6] = "完成";
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
            domainMap["entering"] = (short)1;
            domainMap["waitCheck"] = (short)2;
            domainMap["denyCheck"] = (short)3;
            domainMap["waitApprove"] = (short)4;
            domainMap["denyApprove"] = (short)5;
            domainMap["complete"] = (short)6;
         }
         return (short)domainMap[key] ;
      }

   }

}
