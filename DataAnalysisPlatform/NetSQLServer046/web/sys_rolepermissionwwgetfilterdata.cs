/*
               File: SYS_RolePermissionWWGetFilterData
        Description: SYS_Role Permission WWGet Filter Data
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 11:55:20.51
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
using System.Threading;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class sys_rolepermissionwwgetfilterdata : GXProcedure
   {
      public sys_rolepermissionwwgetfilterdata( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public sys_rolepermissionwwgetfilterdata( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_DDOName ,
                           String aP1_SearchTxt ,
                           String aP2_SearchTxtTo ,
                           out String aP3_OptionsJson ,
                           out String aP4_OptionsDescJson ,
                           out String aP5_OptionIndexesJson )
      {
         this.AV15DDOName = aP0_DDOName;
         this.AV13SearchTxt = aP1_SearchTxt;
         this.AV14SearchTxtTo = aP2_SearchTxtTo;
         this.AV19OptionsJson = "" ;
         this.AV22OptionsDescJson = "" ;
         this.AV24OptionIndexesJson = "" ;
         initialize();
         executePrivate();
         aP3_OptionsJson=this.AV19OptionsJson;
         aP4_OptionsDescJson=this.AV22OptionsDescJson;
         aP5_OptionIndexesJson=this.AV24OptionIndexesJson;
      }

      public String executeUdp( String aP0_DDOName ,
                                String aP1_SearchTxt ,
                                String aP2_SearchTxtTo ,
                                out String aP3_OptionsJson ,
                                out String aP4_OptionsDescJson )
      {
         this.AV15DDOName = aP0_DDOName;
         this.AV13SearchTxt = aP1_SearchTxt;
         this.AV14SearchTxtTo = aP2_SearchTxtTo;
         this.AV19OptionsJson = "" ;
         this.AV22OptionsDescJson = "" ;
         this.AV24OptionIndexesJson = "" ;
         initialize();
         executePrivate();
         aP3_OptionsJson=this.AV19OptionsJson;
         aP4_OptionsDescJson=this.AV22OptionsDescJson;
         aP5_OptionIndexesJson=this.AV24OptionIndexesJson;
         return AV24OptionIndexesJson ;
      }

      public void executeSubmit( String aP0_DDOName ,
                                 String aP1_SearchTxt ,
                                 String aP2_SearchTxtTo ,
                                 out String aP3_OptionsJson ,
                                 out String aP4_OptionsDescJson ,
                                 out String aP5_OptionIndexesJson )
      {
         sys_rolepermissionwwgetfilterdata objsys_rolepermissionwwgetfilterdata;
         objsys_rolepermissionwwgetfilterdata = new sys_rolepermissionwwgetfilterdata();
         objsys_rolepermissionwwgetfilterdata.AV15DDOName = aP0_DDOName;
         objsys_rolepermissionwwgetfilterdata.AV13SearchTxt = aP1_SearchTxt;
         objsys_rolepermissionwwgetfilterdata.AV14SearchTxtTo = aP2_SearchTxtTo;
         objsys_rolepermissionwwgetfilterdata.AV19OptionsJson = "" ;
         objsys_rolepermissionwwgetfilterdata.AV22OptionsDescJson = "" ;
         objsys_rolepermissionwwgetfilterdata.AV24OptionIndexesJson = "" ;
         objsys_rolepermissionwwgetfilterdata.context.SetSubmitInitialConfig(context);
         objsys_rolepermissionwwgetfilterdata.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objsys_rolepermissionwwgetfilterdata);
         aP3_OptionsJson=this.AV19OptionsJson;
         aP4_OptionsDescJson=this.AV22OptionsDescJson;
         aP5_OptionIndexesJson=this.AV24OptionIndexesJson;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((sys_rolepermissionwwgetfilterdata)stateInfo).executePrivate();
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
         AV18Options = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         AV21OptionsDesc = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         AV23OptionIndexes = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         GXt_boolean1 = AV8IsAuthorized;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Role_Manager", out  GXt_boolean1) ;
         AV8IsAuthorized = GXt_boolean1;
         if ( AV8IsAuthorized )
         {
            new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV9WWPContext) ;
            /* Execute user subroutine: 'LOADGRIDSTATE' */
            S111 ();
            if ( returnInSub )
            {
               this.cleanup();
               if (true) return;
            }
            if ( StringUtil.StrCmp(StringUtil.Upper( AV15DDOName), "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE") == 0 )
            {
               /* Execute user subroutine: 'LOADSYS_ROLEPERMISSIONPERMISSIONCODEOPTIONS' */
               S121 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
         }
         AV19OptionsJson = AV18Options.ToJSonString(false);
         AV22OptionsDescJson = AV21OptionsDesc.ToJSonString(false);
         AV24OptionIndexesJson = AV23OptionIndexes.ToJSonString(false);
         this.cleanup();
      }

      protected void S111( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV26Session.Get("SYS_RolePermissionWWGridState"), "") == 0 )
         {
            AV28GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  "SYS_RolePermissionWWGridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         else
         {
            AV28GridState.FromXml(AV26Session.Get("SYS_RolePermissionWWGridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         AV39GXV1 = 1;
         while ( AV39GXV1 <= AV28GridState.gxTpr_Filtervalues.Count )
         {
            AV29GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV28GridState.gxTpr_Filtervalues.Item(AV39GXV1));
            if ( StringUtil.StrCmp(AV29GridStateFilterValue.gxTpr_Name, "SYS_ROLEPERMISSIONPERMISSIONCODE") == 0 )
            {
               AV32SYS_RolePermissionPermissionCode = AV29GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV29GridStateFilterValue.gxTpr_Name, "TFSYS_ROLEPERMISSIONPERMISSIONCODE") == 0 )
            {
               AV11TFSYS_RolePermissionPermissionCode = AV29GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV29GridStateFilterValue.gxTpr_Name, "TFSYS_ROLEPERMISSIONPERMISSIONCODE_SEL") == 0 )
            {
               AV12TFSYS_RolePermissionPermissionCode_Sel = AV29GridStateFilterValue.gxTpr_Value;
            }
            AV39GXV1 = (int)(AV39GXV1+1);
         }
      }

      protected void S121( )
      {
         /* 'LOADSYS_ROLEPERMISSIONPERMISSIONCODEOPTIONS' Routine */
         AV11TFSYS_RolePermissionPermissionCode = AV13SearchTxt;
         AV12TFSYS_RolePermissionPermissionCode_Sel = "";
         AV41SYS_RolePermissionWWDS_1_Sys_rolepermissionpermissioncode = AV32SYS_RolePermissionPermissionCode;
         AV42SYS_RolePermissionWWDS_2_Tfsys_rolepermissionpermissioncode = AV11TFSYS_RolePermissionPermissionCode;
         AV43SYS_RolePermissionWWDS_3_Tfsys_rolepermissionpermissioncode_sel = AV12TFSYS_RolePermissionPermissionCode_Sel;
         pr_datastore1.dynParam(0, new Object[]{ new Object[]{
                                              AV41SYS_RolePermissionWWDS_1_Sys_rolepermissionpermissioncode ,
                                              AV43SYS_RolePermissionWWDS_3_Tfsys_rolepermissionpermissioncode_sel ,
                                              AV42SYS_RolePermissionWWDS_2_Tfsys_rolepermissionpermissioncode ,
                                              A445SYS_RolePermissionPermissionCode } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING
                                              }
         } ) ;
         lV41SYS_RolePermissionWWDS_1_Sys_rolepermissionpermissioncode = StringUtil.Concat( StringUtil.RTrim( AV41SYS_RolePermissionWWDS_1_Sys_rolepermissionpermissioncode), "%", "");
         lV42SYS_RolePermissionWWDS_2_Tfsys_rolepermissionpermissioncode = StringUtil.Concat( StringUtil.RTrim( AV42SYS_RolePermissionWWDS_2_Tfsys_rolepermissionpermissioncode), "%", "");
         /* Using cursor P00472 */
         pr_datastore1.execute(0, new Object[] {lV41SYS_RolePermissionWWDS_1_Sys_rolepermissionpermissioncode, lV42SYS_RolePermissionWWDS_2_Tfsys_rolepermissionpermissioncode, AV43SYS_RolePermissionWWDS_3_Tfsys_rolepermissionpermissioncode_sel});
         while ( (pr_datastore1.getStatus(0) != 101) )
         {
            BRK472 = false;
            A445SYS_RolePermissionPermissionCode = P00472_A445SYS_RolePermissionPermissionCode[0];
            A444SYS_RolePermissionRoleID = (Guid)((Guid)(P00472_A444SYS_RolePermissionRoleID[0]));
            AV25count = 0;
            while ( (pr_datastore1.getStatus(0) != 101) && ( StringUtil.StrCmp(P00472_A445SYS_RolePermissionPermissionCode[0], A445SYS_RolePermissionPermissionCode) == 0 ) )
            {
               BRK472 = false;
               A444SYS_RolePermissionRoleID = (Guid)((Guid)(P00472_A444SYS_RolePermissionRoleID[0]));
               AV25count = (long)(AV25count+1);
               BRK472 = true;
               pr_datastore1.readNext(0);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A445SYS_RolePermissionPermissionCode)) )
            {
               AV17Option = A445SYS_RolePermissionPermissionCode;
               AV18Options.Add(AV17Option, 0);
               AV23OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV25count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV18Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK472 )
            {
               BRK472 = true;
               pr_datastore1.readNext(0);
            }
         }
         pr_datastore1.close(0);
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
         AV18Options = new GxSimpleCollection<String>();
         AV21OptionsDesc = new GxSimpleCollection<String>();
         AV23OptionIndexes = new GxSimpleCollection<String>();
         AV9WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV26Session = context.GetSession();
         AV28GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         AV29GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
         AV32SYS_RolePermissionPermissionCode = "";
         AV11TFSYS_RolePermissionPermissionCode = "";
         AV12TFSYS_RolePermissionPermissionCode_Sel = "";
         AV41SYS_RolePermissionWWDS_1_Sys_rolepermissionpermissioncode = "";
         AV42SYS_RolePermissionWWDS_2_Tfsys_rolepermissionpermissioncode = "";
         AV43SYS_RolePermissionWWDS_3_Tfsys_rolepermissionpermissioncode_sel = "";
         scmdbuf = "";
         lV41SYS_RolePermissionWWDS_1_Sys_rolepermissionpermissioncode = "";
         lV42SYS_RolePermissionWWDS_2_Tfsys_rolepermissionpermissioncode = "";
         A445SYS_RolePermissionPermissionCode = "";
         P00472_A445SYS_RolePermissionPermissionCode = new String[] {""} ;
         P00472_A444SYS_RolePermissionRoleID = new Guid[] {Guid.Empty} ;
         A444SYS_RolePermissionRoleID = (Guid)(Guid.Empty);
         AV17Option = "";
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.sys_rolepermissionwwgetfilterdata__datastore1(),
            new Object[][] {
                new Object[] {
               P00472_A445SYS_RolePermissionPermissionCode, P00472_A444SYS_RolePermissionRoleID
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private int AV39GXV1 ;
      private long AV25count ;
      private String scmdbuf ;
      private bool AV8IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool returnInSub ;
      private bool BRK472 ;
      private String AV24OptionIndexesJson ;
      private String AV19OptionsJson ;
      private String AV22OptionsDescJson ;
      private String AV15DDOName ;
      private String AV13SearchTxt ;
      private String AV14SearchTxtTo ;
      private String AV32SYS_RolePermissionPermissionCode ;
      private String AV11TFSYS_RolePermissionPermissionCode ;
      private String AV12TFSYS_RolePermissionPermissionCode_Sel ;
      private String AV41SYS_RolePermissionWWDS_1_Sys_rolepermissionpermissioncode ;
      private String AV42SYS_RolePermissionWWDS_2_Tfsys_rolepermissionpermissioncode ;
      private String AV43SYS_RolePermissionWWDS_3_Tfsys_rolepermissionpermissioncode_sel ;
      private String lV41SYS_RolePermissionWWDS_1_Sys_rolepermissionpermissioncode ;
      private String lV42SYS_RolePermissionWWDS_2_Tfsys_rolepermissionpermissioncode ;
      private String A445SYS_RolePermissionPermissionCode ;
      private String AV17Option ;
      private Guid A444SYS_RolePermissionRoleID ;
      private IGxSession AV26Session ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_datastore1 ;
      private String[] P00472_A445SYS_RolePermissionPermissionCode ;
      private Guid[] P00472_A444SYS_RolePermissionRoleID ;
      private String aP3_OptionsJson ;
      private String aP4_OptionsDescJson ;
      private String aP5_OptionIndexesJson ;
      private GxSimpleCollection<String> AV18Options ;
      private GxSimpleCollection<String> AV21OptionsDesc ;
      private GxSimpleCollection<String> AV23OptionIndexes ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV9WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV28GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV29GridStateFilterValue ;
   }

   public class sys_rolepermissionwwgetfilterdata__datastore1 : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_P00472( IGxContext context ,
                                             String AV41SYS_RolePermissionWWDS_1_Sys_rolepermissionpermissioncode ,
                                             String AV43SYS_RolePermissionWWDS_3_Tfsys_rolepermissionpermissioncode_sel ,
                                             String AV42SYS_RolePermissionWWDS_2_Tfsys_rolepermissionpermissioncode ,
                                             String A445SYS_RolePermissionPermissionCode )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int2 ;
         GXv_int2 = new short [3] ;
         Object[] GXv_Object3 ;
         GXv_Object3 = new Object [2] ;
         scmdbuf = "SELECT [PermissionCode], [RoleID] FROM [SYS_RolePermission] WITH (NOLOCK)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV41SYS_RolePermissionWWDS_1_Sys_rolepermissionpermissioncode)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PermissionCode] like '%' + @lV41SYS_RolePermissionWWDS_1_Sys_rolepermissionpermissioncode + '%')";
            }
            else
            {
               sWhereString = sWhereString + " ([PermissionCode] like '%' + @lV41SYS_RolePermissionWWDS_1_Sys_rolepermissionpermissioncode + '%')";
            }
         }
         else
         {
            GXv_int2[0] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV43SYS_RolePermissionWWDS_3_Tfsys_rolepermissionpermissioncode_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV42SYS_RolePermissionWWDS_2_Tfsys_rolepermissionpermissioncode)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PermissionCode] like @lV42SYS_RolePermissionWWDS_2_Tfsys_rolepermissionpermissioncode)";
            }
            else
            {
               sWhereString = sWhereString + " ([PermissionCode] like @lV42SYS_RolePermissionWWDS_2_Tfsys_rolepermissionpermissioncode)";
            }
         }
         else
         {
            GXv_int2[1] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV43SYS_RolePermissionWWDS_3_Tfsys_rolepermissionpermissioncode_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PermissionCode] = @AV43SYS_RolePermissionWWDS_3_Tfsys_rolepermissionpermissioncode_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([PermissionCode] = @AV43SYS_RolePermissionWWDS_3_Tfsys_rolepermissionpermissioncode_sel)";
            }
         }
         else
         {
            GXv_int2[2] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         scmdbuf = scmdbuf + " ORDER BY [PermissionCode]";
         GXv_Object3[0] = scmdbuf;
         GXv_Object3[1] = GXv_int2;
         return GXv_Object3 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     IGxContext context ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_P00472(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] );
         }
         return base.getDynamicStatement(cursor, context, dynConstraints);
      }

      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP00472 ;
          prmP00472 = new Object[] {
          new Object[] {"@lV41SYS_RolePermissionWWDS_1_Sys_rolepermissionpermissioncode",SqlDbType.NVarChar,64,0} ,
          new Object[] {"@lV42SYS_RolePermissionWWDS_2_Tfsys_rolepermissionpermissioncode",SqlDbType.NVarChar,64,0} ,
          new Object[] {"@AV43SYS_RolePermissionWWDS_3_Tfsys_rolepermissionpermissioncode_sel",SqlDbType.NVarChar,64,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00472", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00472,100,0,true,false )
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
             case 0 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((Guid[]) buf[1])[0] = rslt.getGuid(2) ;
                return;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       short sIdx ;
       switch ( cursor )
       {
             case 0 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[3]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[4]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[5]);
                }
                return;
       }
    }

    public String getDataStoreName( )
    {
       return "DATASTORE1";
    }

 }

 [ServiceContract(Namespace = "GeneXus.Programs.sys_rolepermissionwwgetfilterdata_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class sys_rolepermissionwwgetfilterdata_services : GxRestService
 {
    [OperationContract]
    [WebInvoke(Method =  "POST" ,
    	BodyStyle =  WebMessageBodyStyle.Wrapped  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/")]
    public void execute( String DDOName ,
                         String SearchTxt ,
                         String SearchTxtTo ,
                         out String OptionsJson ,
                         out String OptionsDescJson ,
                         out String OptionIndexesJson )
    {
       OptionsJson = "" ;
       OptionsDescJson = "" ;
       OptionIndexesJson = "" ;
       try
       {
          if ( ! ProcessHeaders("sys_rolepermissionwwgetfilterdata") )
          {
             return  ;
          }
          sys_rolepermissionwwgetfilterdata worker = new sys_rolepermissionwwgetfilterdata(context) ;
          worker.IsMain = RunAsMain ;
          worker.execute(DDOName,SearchTxt,SearchTxtTo,out OptionsJson,out OptionsDescJson,out OptionIndexesJson );
          worker.cleanup( );
       }
       catch ( Exception e )
       {
          WebException(e);
       }
       finally
       {
          Cleanup();
       }
    }

 }

}
