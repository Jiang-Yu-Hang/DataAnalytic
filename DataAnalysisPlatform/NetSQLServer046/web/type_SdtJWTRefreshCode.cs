/*
               File: type_SdtJWTRefreshCode
        Description: JWTRefreshCode
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 12:7:58.50
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
   public class SdtJWTRefreshCode : GxUserType, IGxExternalObject
   {
      public SdtJWTRefreshCode( )
      {
         /* Constructor for serialization */
      }

      public SdtJWTRefreshCode( IGxContext context )
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

      public String refreshcode( String gxTp_token )
      {
         String returnrefreshcode ;
         if ( JWTRefreshCode_externalReference == null )
         {
            JWTRefreshCode_externalReference = new api.Controllers.JWTRefreshCode();
         }
         returnrefreshcode = "";
         returnrefreshcode = (String)(JWTRefreshCode_externalReference.RefreshCode(gxTp_token));
         return returnrefreshcode ;
      }

      public String encode( String gxTp_user )
      {
         String returnencode ;
         if ( JWTRefreshCode_externalReference == null )
         {
            JWTRefreshCode_externalReference = new api.Controllers.JWTRefreshCode();
         }
         returnencode = "";
         returnencode = (String)(JWTRefreshCode_externalReference.Encode(gxTp_user));
         return returnencode ;
      }

      public Object ExternalInstance
      {
         get {
            if ( JWTRefreshCode_externalReference == null )
            {
               JWTRefreshCode_externalReference = new api.Controllers.JWTRefreshCode();
            }
            return JWTRefreshCode_externalReference ;
         }

         set {
            JWTRefreshCode_externalReference = (api.Controllers.JWTRefreshCode)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected api.Controllers.JWTRefreshCode JWTRefreshCode_externalReference=null ;
   }

}
