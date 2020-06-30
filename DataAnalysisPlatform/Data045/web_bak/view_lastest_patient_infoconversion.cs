/*
               File: view_lastest_patient_infoConversion
        Description: Conversion for table view_lastest_patient_info
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 6/14/2019 16:9:23.39
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
using GeneXus.Reorg;
using System.Threading;
using GeneXus.Programs;
using System.Web.Services;
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
using System.Xml.Serialization;
namespace GeneXus.Programs {
   public class view_lastest_patient_infoconversion : GXProcedure
   {
      public view_lastest_patient_infoconversion( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public view_lastest_patient_infoconversion( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( )
      {
         initialize();
         executePrivate();
      }

      public void executeSubmit( )
      {
         view_lastest_patient_infoconversion objview_lastest_patient_infoconversion;
         objview_lastest_patient_infoconversion = new view_lastest_patient_infoconversion();
         objview_lastest_patient_infoconversion.context.SetSubmitInitialConfig(context);
         objview_lastest_patient_infoconversion.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objview_lastest_patient_infoconversion);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((view_lastest_patient_infoconversion)stateInfo).executePrivate();
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
         /* Using cursor VIEW_LASTE2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A524VIEW_LPI_BR_Demographics_Ethnic = VIEW_LASTE2_A524VIEW_LPI_BR_Demographics_Ethnic[0];
            A523VIEW_LPI_BR_Demographics_BirthDate = VIEW_LASTE2_A523VIEW_LPI_BR_Demographics_BirthDate[0];
            A522VIEW_LPI_BR_Demographics_Sex = VIEW_LASTE2_A522VIEW_LPI_BR_Demographics_Sex[0];
            A519VIEW_LPI_BR_Information_PatientNo = VIEW_LASTE2_A519VIEW_LPI_BR_Information_PatientNo[0];
            A520VIEW_LPI_BR_Information_ID = VIEW_LASTE2_A520VIEW_LPI_BR_Information_ID[0];
            A521VIEW_LPI_BR_Encounter_AdmitDate = VIEW_LASTE2_A521VIEW_LPI_BR_Encounter_AdmitDate[0];
            A40000GXC1 = ( A521VIEW_LPI_BR_Encounter_AdmitDate);
            /*
               INSERT RECORD ON TABLE GXA0071

            */
            AV2VIEW_LPI_BR_Information_ID = A520VIEW_LPI_BR_Information_ID;
            AV3VIEW_LPI_BR_Information_PatientNo = A519VIEW_LPI_BR_Information_PatientNo;
            AV4VIEW_LPI_BR_Encounter_AdmitDate = A40000GXC1;
            AV5VIEW_LPI_BR_Demographics_Sex = A522VIEW_LPI_BR_Demographics_Sex;
            AV6VIEW_LPI_BR_Demographics_BirthDate = A523VIEW_LPI_BR_Demographics_BirthDate;
            AV7VIEW_LPI_BR_Demographics_Ethnic = A524VIEW_LPI_BR_Demographics_Ethnic;
            /* Using cursor VIEW_LASTE3 */
            pr_default.execute(1, new Object[] {AV2VIEW_LPI_BR_Information_ID, AV3VIEW_LPI_BR_Information_PatientNo, AV4VIEW_LPI_BR_Encounter_AdmitDate, AV5VIEW_LPI_BR_Demographics_Sex, AV6VIEW_LPI_BR_Demographics_BirthDate, AV7VIEW_LPI_BR_Demographics_Ethnic});
            pr_default.close(1);
            dsDefault.SmartCacheProvider.SetUpdated("GXA0071") ;
            if ( (pr_default.getStatus(1) == 1) )
            {
               context.Gx_err = 1;
               Gx_emsg = (String)(GXResourceManager.GetMessage("GXM_noupdate"));
            }
            else
            {
               context.Gx_err = 0;
               Gx_emsg = "";
            }
            /* End Insert */
            pr_default.readNext(0);
         }
         pr_default.close(0);
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
         scmdbuf = "";
         VIEW_LASTE2_A524VIEW_LPI_BR_Demographics_Ethnic = new String[] {""} ;
         VIEW_LASTE2_A523VIEW_LPI_BR_Demographics_BirthDate = new DateTime[] {DateTime.MinValue} ;
         VIEW_LASTE2_A522VIEW_LPI_BR_Demographics_Sex = new String[] {""} ;
         VIEW_LASTE2_A519VIEW_LPI_BR_Information_PatientNo = new String[] {""} ;
         VIEW_LASTE2_A520VIEW_LPI_BR_Information_ID = new long[1] ;
         VIEW_LASTE2_A521VIEW_LPI_BR_Encounter_AdmitDate = new DateTime[] {DateTime.MinValue} ;
         A524VIEW_LPI_BR_Demographics_Ethnic = "";
         A523VIEW_LPI_BR_Demographics_BirthDate = DateTime.MinValue;
         A522VIEW_LPI_BR_Demographics_Sex = "";
         A519VIEW_LPI_BR_Information_PatientNo = "";
         A521VIEW_LPI_BR_Encounter_AdmitDate = DateTime.MinValue;
         A40000GXC1 = (DateTime)(DateTime.MinValue);
         AV3VIEW_LPI_BR_Information_PatientNo = "";
         AV4VIEW_LPI_BR_Encounter_AdmitDate = (DateTime)(DateTime.MinValue);
         AV5VIEW_LPI_BR_Demographics_Sex = "";
         AV6VIEW_LPI_BR_Demographics_BirthDate = DateTime.MinValue;
         AV7VIEW_LPI_BR_Demographics_Ethnic = "";
         Gx_emsg = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.view_lastest_patient_infoconversion__default(),
            new Object[][] {
                new Object[] {
               VIEW_LASTE2_A524VIEW_LPI_BR_Demographics_Ethnic, VIEW_LASTE2_A523VIEW_LPI_BR_Demographics_BirthDate, VIEW_LASTE2_A522VIEW_LPI_BR_Demographics_Sex, VIEW_LASTE2_A519VIEW_LPI_BR_Information_PatientNo, VIEW_LASTE2_A520VIEW_LPI_BR_Information_ID, VIEW_LASTE2_A521VIEW_LPI_BR_Encounter_AdmitDate
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private int GIGXA0071 ;
      private long A520VIEW_LPI_BR_Information_ID ;
      private long AV2VIEW_LPI_BR_Information_ID ;
      private String scmdbuf ;
      private String Gx_emsg ;
      private DateTime A40000GXC1 ;
      private DateTime AV4VIEW_LPI_BR_Encounter_AdmitDate ;
      private DateTime A523VIEW_LPI_BR_Demographics_BirthDate ;
      private DateTime A521VIEW_LPI_BR_Encounter_AdmitDate ;
      private DateTime AV6VIEW_LPI_BR_Demographics_BirthDate ;
      private String A524VIEW_LPI_BR_Demographics_Ethnic ;
      private String A522VIEW_LPI_BR_Demographics_Sex ;
      private String A519VIEW_LPI_BR_Information_PatientNo ;
      private String AV3VIEW_LPI_BR_Information_PatientNo ;
      private String AV5VIEW_LPI_BR_Demographics_Sex ;
      private String AV7VIEW_LPI_BR_Demographics_Ethnic ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] VIEW_LASTE2_A524VIEW_LPI_BR_Demographics_Ethnic ;
      private DateTime[] VIEW_LASTE2_A523VIEW_LPI_BR_Demographics_BirthDate ;
      private String[] VIEW_LASTE2_A522VIEW_LPI_BR_Demographics_Sex ;
      private String[] VIEW_LASTE2_A519VIEW_LPI_BR_Information_PatientNo ;
      private long[] VIEW_LASTE2_A520VIEW_LPI_BR_Information_ID ;
      private DateTime[] VIEW_LASTE2_A521VIEW_LPI_BR_Encounter_AdmitDate ;
   }

   public class view_lastest_patient_infoconversion__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new UpdateCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmVIEW_LASTE2 ;
          prmVIEW_LASTE2 = new Object[] {
          } ;
          Object[] prmVIEW_LASTE3 ;
          prmVIEW_LASTE3 = new Object[] {
          new Object[] {"@AV2VIEW_LPI_BR_Information_ID",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV3VIEW_LPI_BR_Information_PatientNo",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV4VIEW_LPI_BR_Encounter_AdmitDate",SqlDbType.DateTime,10,8} ,
          new Object[] {"@AV5VIEW_LPI_BR_Demographics_Sex",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV6VIEW_LPI_BR_Demographics_BirthDate",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV7VIEW_LPI_BR_Demographics_Ethnic",SqlDbType.NVarChar,4000,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("VIEW_LASTE2", "SELECT [VIEW_LPI_BR_Demographics_Ethnic], [VIEW_LPI_BR_Demographics_BirthDate], [VIEW_LPI_BR_Demographics_Sex], [VIEW_LPI_BR_Information_PatientNo], [VIEW_LPI_BR_Information_ID], [VIEW_LPI_BR_Encounter_AdmitDate] FROM dbo.[view_lastest_patient_info] ORDER BY [VIEW_LPI_BR_Information_ID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmVIEW_LASTE2,100,0,true,false )
             ,new CursorDef("VIEW_LASTE3", "INSERT INTO [GXA0071]([VIEW_LPI_BR_Information_ID], [VIEW_LPI_BR_Information_PatientNo], [VIEW_LPI_BR_Encounter_AdmitDate], [VIEW_LPI_BR_Demographics_Sex], [VIEW_LPI_BR_Demographics_BirthDate], [VIEW_LPI_BR_Demographics_Ethnic]) VALUES(@AV2VIEW_LPI_BR_Information_ID, @AV3VIEW_LPI_BR_Information_PatientNo, @AV4VIEW_LPI_BR_Encounter_AdmitDate, @AV5VIEW_LPI_BR_Demographics_Sex, @AV6VIEW_LPI_BR_Demographics_BirthDate, @AV7VIEW_LPI_BR_Demographics_Ethnic)", GxErrorMask.GX_NOMASK,prmVIEW_LASTE3)
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
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((long[]) buf[4])[0] = rslt.getLong(5) ;
                ((DateTime[]) buf[5])[0] = rslt.getGXDate(6) ;
                return;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 1 :
                stmt.SetParameter(1, (long)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameterDatetime(3, (DateTime)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (DateTime)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                return;
       }
    }

 }

}
