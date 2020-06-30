/*
               File: type_SdtEncrypt_Method
        Description: Encrypt_Method
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:17:56.35
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
   public class SdtEncrypt_Method : GxUserType, IGxExternalObject
   {
      public SdtEncrypt_Method( )
      {
         /* Constructor for serialization */
      }

      public SdtEncrypt_Method( IGxContext context )
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

      public String des_encode( String gxTp_password ,
                                String gxTp_key )
      {
         String returndes_encode ;
         if ( Encrypt_Method_externalReference == null )
         {
            Encrypt_Method_externalReference = new GX_Method.Utils.Encrypt_Method();
         }
         returndes_encode = "";
         returndes_encode = (String)(Encrypt_Method_externalReference.DES_Encode(gxTp_password, gxTp_key));
         return returndes_encode ;
      }

      public String des_decode( String gxTp_password ,
                                String gxTp_key )
      {
         String returndes_decode ;
         if ( Encrypt_Method_externalReference == null )
         {
            Encrypt_Method_externalReference = new GX_Method.Utils.Encrypt_Method();
         }
         returndes_decode = "";
         returndes_decode = (String)(Encrypt_Method_externalReference.DES_Decode(gxTp_password, gxTp_key));
         return returndes_decode ;
      }

      public String genarate_key( )
      {
         String returngenarate_key ;
         if ( Encrypt_Method_externalReference == null )
         {
            Encrypt_Method_externalReference = new GX_Method.Utils.Encrypt_Method();
         }
         returngenarate_key = "";
         returngenarate_key = (String)(Encrypt_Method_externalReference.Genarate_Key());
         return returngenarate_key ;
      }

      public Object ExternalInstance
      {
         get {
            if ( Encrypt_Method_externalReference == null )
            {
               Encrypt_Method_externalReference = new GX_Method.Utils.Encrypt_Method();
            }
            return Encrypt_Method_externalReference ;
         }

         set {
            Encrypt_Method_externalReference = (GX_Method.Utils.Encrypt_Method)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected GX_Method.Utils.Encrypt_Method Encrypt_Method_externalReference=null ;
   }

}
