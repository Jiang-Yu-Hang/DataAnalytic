/*
               File: type_SdtJWTEncode
        Description: JWTEncode
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 12:7:58.49
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
   public class SdtJWTEncode : GxUserType, IGxExternalObject
   {
      public SdtJWTEncode( )
      {
         /* Constructor for serialization */
      }

      public SdtJWTEncode( IGxContext context )
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

      public int testadd( )
      {
         int returntestadd ;
         if ( JWTEncode_externalReference == null )
         {
            JWTEncode_externalReference = new api.Controllers.JWTEncode();
         }
         returntestadd = 0;
         returntestadd = (int)(JWTEncode_externalReference.testAdd());
         return returntestadd ;
      }

      public String encode( String gxTp_user )
      {
         String returnencode ;
         if ( JWTEncode_externalReference == null )
         {
            JWTEncode_externalReference = new api.Controllers.JWTEncode();
         }
         returnencode = "";
         returnencode = (String)(JWTEncode_externalReference.Encode(gxTp_user));
         return returnencode ;
      }

      public Object ExternalInstance
      {
         get {
            if ( JWTEncode_externalReference == null )
            {
               JWTEncode_externalReference = new api.Controllers.JWTEncode();
            }
            return JWTEncode_externalReference ;
         }

         set {
            JWTEncode_externalReference = (api.Controllers.JWTEncode)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected api.Controllers.JWTEncode JWTEncode_externalReference=null ;
   }

}
