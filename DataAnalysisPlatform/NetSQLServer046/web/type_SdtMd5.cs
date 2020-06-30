/*
               File: type_SdtMd5
        Description: Md5
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 12:7:58.51
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
using System.Web.Services.Protocols;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Reflection;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   [Serializable]
   public class SdtMd5 : GxUserType, IGxExternalObject
   {
      public SdtMd5( )
      {
         /* Constructor for serialization */
      }

      public SdtMd5( IGxContext context )
      {
         this.context = context;
         initialize();
      }

      private static Hashtable mapper;
      public override String JsonMap( String value )
      {
         if ( mapper == null )
         {
            mapper = new Hashtable();
         }
         return (String)mapper[value]; ;
      }

      public String getstringmd5( String gxTp_textoOrig )
      {
         String returngetstringmd5 ;
         returngetstringmd5 = "";
         returngetstringmd5 = (String)(Md5Library.Md5.getStringMd5(gxTp_textoOrig));
         return returngetstringmd5 ;
      }

      public Object ExternalInstance
      {
         get {
            if ( Md5_externalReference == null )
            {
               Md5_externalReference = new Md5Library.Md5();
            }
            return Md5_externalReference ;
         }

         set {
            Md5_externalReference = (Md5Library.Md5)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected Md5Library.Md5 Md5_externalReference=null ;
   }

}
