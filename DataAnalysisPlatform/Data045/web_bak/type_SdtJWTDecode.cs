/*
               File: type_SdtJWTDecode
        Description: JWTDecode
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:48:46.87
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
   public class SdtJWTDecode : GxUserType, IGxExternalObject
   {
      public SdtJWTDecode( )
      {
         /* Constructor for serialization */
      }

      public SdtJWTDecode( IGxContext context )
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

      public String decode( String gxTp_token )
      {
         String returndecode ;
         if ( JWTDecode_externalReference == null )
         {
            JWTDecode_externalReference = new api.Controllers.JWTDecode();
         }
         returndecode = "";
         returndecode = (String)(JWTDecode_externalReference.Decode(gxTp_token));
         return returndecode ;
      }

      public Object ExternalInstance
      {
         get {
            if ( JWTDecode_externalReference == null )
            {
               JWTDecode_externalReference = new api.Controllers.JWTDecode();
            }
            return JWTDecode_externalReference ;
         }

         set {
            JWTDecode_externalReference = (api.Controllers.JWTDecode)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected api.Controllers.JWTDecode JWTDecode_externalReference=null ;
   }

}
