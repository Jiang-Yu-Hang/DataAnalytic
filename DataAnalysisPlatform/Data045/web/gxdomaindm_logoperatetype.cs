/*
               File: DM_LogOperateType
        Description: DM_LogOperateType
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:17:55.75
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
   public class gxdomaindm_logoperatetype
   {
      private static Hashtable domain = new Hashtable();
      private static Hashtable domainMap;
      static gxdomaindm_logoperatetype ()
      {
         domain["Create"] = "����";
         domain["Update"] = "�༭";
         domain["Delete"] = "ɾ��";
         domain["Create"] = "����";
         domain["Submit"] = "�ύ����";
         domain["Batchcheck"] = "��������";
         domain["Batchapprove"] = "��������";
         domain["Randomcheckpass"] = "������ͨ��";
         domain["Randomcheckrefuse"] = "�����鲻ͨ��";
         domain["Randomapprovepass"] = "������ͨ��";
         domain["Randomapproverefuse"] = "�����鲻ͨ��";
         domain["Check"] = "����ͨ��";
         domain["Approve"] = "����ͨ��";
         domain["Reupdate"] = "�����޸�";
         domain["Login"] = "��¼";
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
            domainMap["insert"] = "Create";
            domainMap["update"] = "Update";
            domainMap["delete"] = "Delete";
            domainMap["save"] = "Create";
            domainMap["submit"] = "Submit";
            domainMap["batchcheck"] = "Batchcheck";
            domainMap["batchapprove"] = "Batchapprove";
            domainMap["randomcheckpass"] = "Randomcheckpass";
            domainMap["randomcheckrefuse"] = "Randomcheckrefuse";
            domainMap["randomapprovepass"] = "Randomapprovepass";
            domainMap["randomapproverefuse"] = "Randomapproverefuse";
            domainMap["check"] = "Check";
            domainMap["approve"] = "Approve";
            domainMap["reupdate"] = "Reupdate";
            domainMap["login"] = "Login";
         }
         return (String)domainMap[key] ;
      }

   }

}
