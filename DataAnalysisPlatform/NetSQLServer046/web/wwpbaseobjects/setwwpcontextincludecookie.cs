/*
               File: WWPBaseObjects.SetWWPContextIncludeCookie
        Description: 设置用户cookie以及session来保存用户相关信息的方法
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 11:58:8.30
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
using System.Data;
using GeneXus.Data;
using com.genexus;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.Procedure;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using GeneXus.Http.Server;
using System.Threading;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs.wwpbaseobjects {
   public class setwwpcontextincludecookie : GXProcedure
   {
      public setwwpcontextincludecookie( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public setwwpcontextincludecookie( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( GeneXus.Programs.wwpbaseobjects.SdtWWPContext aP0_Context ,
                           String aP1_tClientAddress ,
                           Guid aP2_iUserID ,
                           String aP3_iDisplayName ,
                           out String aP4_oCodes ,
                           out String aP5_tUserType )
      {
         this.AV8Context = aP0_Context;
         this.AV11tClientAddress = aP1_tClientAddress;
         this.AV19iUserID = aP2_iUserID;
         this.AV36iDisplayName = aP3_iDisplayName;
         this.AV27oCodes = "" ;
         this.AV35tUserType = "" ;
         initialize();
         executePrivate();
         aP4_oCodes=this.AV27oCodes;
         aP5_tUserType=this.AV35tUserType;
      }

      public String executeUdp( GeneXus.Programs.wwpbaseobjects.SdtWWPContext aP0_Context ,
                                String aP1_tClientAddress ,
                                Guid aP2_iUserID ,
                                String aP3_iDisplayName ,
                                out String aP4_oCodes )
      {
         this.AV8Context = aP0_Context;
         this.AV11tClientAddress = aP1_tClientAddress;
         this.AV19iUserID = aP2_iUserID;
         this.AV36iDisplayName = aP3_iDisplayName;
         this.AV27oCodes = "" ;
         this.AV35tUserType = "" ;
         initialize();
         executePrivate();
         aP4_oCodes=this.AV27oCodes;
         aP5_tUserType=this.AV35tUserType;
         return AV35tUserType ;
      }

      public void executeSubmit( GeneXus.Programs.wwpbaseobjects.SdtWWPContext aP0_Context ,
                                 String aP1_tClientAddress ,
                                 Guid aP2_iUserID ,
                                 String aP3_iDisplayName ,
                                 out String aP4_oCodes ,
                                 out String aP5_tUserType )
      {
         setwwpcontextincludecookie objsetwwpcontextincludecookie;
         objsetwwpcontextincludecookie = new setwwpcontextincludecookie();
         objsetwwpcontextincludecookie.AV8Context = aP0_Context;
         objsetwwpcontextincludecookie.AV11tClientAddress = aP1_tClientAddress;
         objsetwwpcontextincludecookie.AV19iUserID = aP2_iUserID;
         objsetwwpcontextincludecookie.AV36iDisplayName = aP3_iDisplayName;
         objsetwwpcontextincludecookie.AV27oCodes = "" ;
         objsetwwpcontextincludecookie.AV35tUserType = "" ;
         objsetwwpcontextincludecookie.context.SetSubmitInitialConfig(context);
         objsetwwpcontextincludecookie.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objsetwwpcontextincludecookie);
         aP4_oCodes=this.AV27oCodes;
         aP5_tUserType=this.AV35tUserType;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((setwwpcontextincludecookie)stateInfo).executePrivate();
         }
         catch ( Exception e )
         {
            GXUtil.SaveToEventLog( "VersionAssociateWMicro", e);
            throw e ;
         }
      }

      void executePrivate( )
      {
         /* GeneXus formulas */
         /* Output device settings */
         AV13tNowDate = DateTimeUtil.ServerNow( context, pr_default);
         AV15tSessionID = StringUtil.Trim( AV10Session.Id);
         AV14tSDT_JWT = new SdtSDT_JWT(context);
         AV14tSDT_JWT.gxTpr_Name = AV8Context.gxTpr_Username;
         AV14tSDT_JWT.gxTpr_Userid = StringUtil.Trim( AV19iUserID.ToString());
         AV14tSDT_JWT.gxTpr_Sessionid = AV15tSessionID;
         AV14tSDT_JWT.gxTpr_Ip = AV11tClientAddress;
         AV14tSDT_JWT.gxTpr_Nbf = "123421423";
         AV14tSDT_JWT.gxTpr_Exp = "1740576564857";
         AV14tSDT_JWT.gxTpr_Iss = "das";
         AV14tSDT_JWT.gxTpr_Aud = "das";
         AV14tSDT_JWT.gxTpr_Iat = "124124214";
         AV12tJWTTokenContent = AV17JWTEncode.encode(AV14tSDT_JWT.ToJSonString(false));
         AV20BCSYS_User.Load(AV19iUserID);
         AV20BCSYS_User.gxTpr_Loginip = StringUtil.Trim( AV11tClientAddress);
         AV20BCSYS_User.gxTpr_Logintime = AV13tNowDate;
         AV20BCSYS_User.Save();
         context.CommitDataStores("wwpbaseobjects.setwwpcontextincludecookie",pr_default);
         AV40jwtcookie.Name = "DAS_LoginUser";
         AV40jwtcookie.CurrentValue = AV12tJWTTokenContent;
         AV40jwtcookie.Path = "/";
         AV40jwtcookie.HttpOnly = false;
         AV37httpresponse.SetCookie(AV40jwtcookie);
         AV39BCXT_Config.Load(6);
         AV22httpclient.Host = StringUtil.Trim( AV39BCXT_Config.gxTpr_Xt_configvalue3);
         AV22httpclient.AddHeader("Connection", "keep-alive");
         AV22httpclient.AddHeader("Content-Type", "application/json; charset=utf-8");
         AV23tCookieContent = "DAS_LoginUser=" + StringUtil.Trim( AV12tJWTTokenContent) + ";";
         AV22httpclient.AddHeader("Cookie", AV23tCookieContent);
         AV22httpclient.Execute("Get", "/api/User/getpermission?userid="+StringUtil.Trim( AV19iUserID.ToString()));
         AV24tResult = StringUtil.Trim( AV22httpclient.ToString());
         AV25tSDT_MicroUserInfo.FromJSonString(AV24tResult, null);
         AV26oTenantsCodes.Clear();
         AV43I = 1;
         while ( AV43I <= AV25tSDT_MicroUserInfo.gxTpr_Tenants.Count )
         {
            AV26oTenantsCodes.Add(StringUtil.Trim( ((SdtSDT_MicroUserInfo_Tenants)AV25tSDT_MicroUserInfo.gxTpr_Tenants.Item(AV43I)).gxTpr_Code), 0);
            AV43I = (short)(AV43I+1);
         }
         AV27oCodes = AV26oTenantsCodes.ToJSonString(false);
         AV8Context.gxTpr_Currenttnum = (short)(AV26oTenantsCodes.Count);
         AV8Context.gxTpr_Usertype = AV25tSDT_MicroUserInfo.gxTpr_Usertype;
         AV8Context.gxTpr_Clientip = AV11tClientAddress;
         AV18tContent = Encrypt64( AV8Context.ToXml(false, true, "WWPContext", "DataAnalysisPlatform"), "A803C9281F6C819705ADF9E4208BE89C");
         AV38cookie.Name = "GX_Cookie";
         AV38cookie.CurrentValue = AV18tContent;
         AV38cookie.Path = "/";
         AV38cookie.HttpOnly = false;
         AV37httpresponse.SetCookie(AV38cookie);
         if ( AV26oTenantsCodes.Count == 1 )
         {
            AV38cookie = new GxHttpCookie();
            AV38cookie.Name = "DAS_UserTInfo";
            AV38cookie.CurrentValue = StringUtil.Trim( ((String)AV26oTenantsCodes.Item(1)));
            AV38cookie.Path = "/";
            AV38cookie.HttpOnly = false;
            AV37httpresponse.SetCookie(AV38cookie);
            new zutil_recordlog(context ).execute(  "",  "",  "Login",  2) ;
         }
         this.cleanup();
      }

      public override void cleanup( )
      {
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
         exitApplication();
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         AV13tNowDate = (DateTime)(DateTime.MinValue);
         AV15tSessionID = "";
         AV10Session = context.GetSession();
         AV14tSDT_JWT = new SdtSDT_JWT(context);
         AV12tJWTTokenContent = "";
         AV17JWTEncode = new SdtJWTEncode(context);
         AV20BCSYS_User = new SdtSYS_User(context);
         AV40jwtcookie = new GxHttpCookie();
         AV37httpresponse = new GxHttpResponse( context);
         AV39BCXT_Config = new SdtXT_Config(context);
         AV22httpclient = new GxHttpClient( context);
         AV23tCookieContent = "";
         AV24tResult = "";
         AV25tSDT_MicroUserInfo = new SdtSDT_MicroUserInfo(context);
         AV26oTenantsCodes = new GxSimpleCollection<String>();
         AV18tContent = "";
         AV38cookie = new GxHttpCookie();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.wwpbaseobjects.setwwpcontextincludecookie__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wwpbaseobjects.setwwpcontextincludecookie__default(),
            new Object[][] {
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV43I ;
      private DateTime AV13tNowDate ;
      private String AV23tCookieContent ;
      private String AV11tClientAddress ;
      private String AV36iDisplayName ;
      private String AV35tUserType ;
      private String AV15tSessionID ;
      private String AV12tJWTTokenContent ;
      private String AV24tResult ;
      private String AV27oCodes ;
      private String AV18tContent ;
      private Guid AV19iUserID ;
      private SdtJWTEncode AV17JWTEncode ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String aP4_oCodes ;
      private String aP5_tUserType ;
      private IDataStoreProvider pr_datastore1 ;
      private GxHttpCookie AV40jwtcookie ;
      private GxHttpCookie AV38cookie ;
      private GxHttpClient AV22httpclient ;
      private GxHttpResponse AV37httpresponse ;
      private IGxSession AV10Session ;
      private GxSimpleCollection<String> AV26oTenantsCodes ;
      private SdtSYS_User AV20BCSYS_User ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV8Context ;
      private SdtSDT_JWT AV14tSDT_JWT ;
      private SdtSDT_MicroUserInfo AV25tSDT_MicroUserInfo ;
      private SdtXT_Config AV39BCXT_Config ;
   }

   public class setwwpcontextincludecookie__datastore1 : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          def= new CursorDef[] {
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
       }
    }

    public String getDataStoreName( )
    {
       return "DATASTORE1";
    }

 }

 public class setwwpcontextincludecookie__default : DataStoreHelperBase, IDataStoreHelper
 {
    public ICursor[] getCursors( )
    {
       cursorDefinitions();
       return new Cursor[] {
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        def= new CursorDef[] {
        };
     }
  }

  public void getResults( int cursor ,
                          IFieldGetter rslt ,
                          Object[] buf )
  {
     switch ( cursor )
     {
     }
  }

  public void setParameters( int cursor ,
                             IFieldSetter stmt ,
                             Object[] parms )
  {
     switch ( cursor )
     {
     }
  }

}

}
