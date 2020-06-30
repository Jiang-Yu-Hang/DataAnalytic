/*
               File: type_Sdtcode
        Description: code
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 7/31/2019 17:13:29.60
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
   public class Sdtcode : GxUserType, IGxExternalObject
   {
      public Sdtcode( )
      {
         /* Constructor for serialization */
      }

      public Sdtcode( IGxContext context )
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

      public String qr( String gxTp_msg )
      {
         String returnqr ;
         returnqr = "";
         returnqr = (String)(QRCode.Controllers.code.QR(gxTp_msg));
         return returnqr ;
      }

      public Object ExternalInstance
      {
         get {
            if ( code_externalReference == null )
            {
               code_externalReference = new QRCode.Controllers.code();
            }
            return code_externalReference ;
         }

         set {
            code_externalReference = (QRCode.Controllers.code)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected QRCode.Controllers.code code_externalReference=null ;
   }

}
