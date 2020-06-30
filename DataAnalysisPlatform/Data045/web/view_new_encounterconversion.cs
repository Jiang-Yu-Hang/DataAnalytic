/*
               File: View_New_EncounterConversion
        Description: Conversion for table View_New_Encounter
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 10:53:15.68
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
   public class view_new_encounterconversion : GXProcedure
   {
      public view_new_encounterconversion( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore2 = context.GetDataStore("DataStore2");
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public view_new_encounterconversion( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore2 = context.GetDataStore("DataStore2");
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
         view_new_encounterconversion objview_new_encounterconversion;
         objview_new_encounterconversion = new view_new_encounterconversion();
         objview_new_encounterconversion.context.SetSubmitInitialConfig(context);
         objview_new_encounterconversion.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objview_new_encounterconversion);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((view_new_encounterconversion)stateInfo).executePrivate();
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
         /* Using cursor VIEW_NEW_E2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A601View_New_Encounter2view_NE_Information_PatientNo = VIEW_NEW_E2_A601View_New_Encounter2view_NE_Information_PatientNo[0];
            n601View_New_Encounter2view_NE_Information_PatientNo = VIEW_NEW_E2_n601View_New_Encounter2view_NE_Information_PatientNo[0];
            A600View_New_Encounter2view_NE_Information_ID = VIEW_NEW_E2_A600View_New_Encounter2view_NE_Information_ID[0];
            n600View_New_Encounter2view_NE_Information_ID = VIEW_NEW_E2_n600View_New_Encounter2view_NE_Information_ID[0];
            A599View_New_Encounter2view_NE_TenantTenantCode = VIEW_NEW_E2_A599View_New_Encounter2view_NE_TenantTenantCode[0];
            n599View_New_Encounter2view_NE_TenantTenantCode = VIEW_NEW_E2_n599View_New_Encounter2view_NE_TenantTenantCode[0];
            A598View_New_Encounter2view_NE_IsUpdate = VIEW_NEW_E2_A598View_New_Encounter2view_NE_IsUpdate[0];
            n598View_New_Encounter2view_NE_IsUpdate = VIEW_NEW_E2_n598View_New_Encounter2view_NE_IsUpdate[0];
            A597View_New_Encounter2view_NE_IsRandApprove = VIEW_NEW_E2_A597View_New_Encounter2view_NE_IsRandApprove[0];
            n597View_New_Encounter2view_NE_IsRandApprove = VIEW_NEW_E2_n597View_New_Encounter2view_NE_IsRandApprove[0];
            A596View_New_Encounter2view_NE_IsRandRecheck = VIEW_NEW_E2_A596View_New_Encounter2view_NE_IsRandRecheck[0];
            n596View_New_Encounter2view_NE_IsRandRecheck = VIEW_NEW_E2_n596View_New_Encounter2view_NE_IsRandRecheck[0];
            A595View_New_Encounter2view_NE_Status = VIEW_NEW_E2_A595View_New_Encounter2view_NE_Status[0];
            n595View_New_Encounter2view_NE_Status = VIEW_NEW_E2_n595View_New_Encounter2view_NE_Status[0];
            A593View_New_Encounter2view_NE_Departmentadm = VIEW_NEW_E2_A593View_New_Encounter2view_NE_Departmentadm[0];
            n593View_New_Encounter2view_NE_Departmentadm = VIEW_NEW_E2_n593View_New_Encounter2view_NE_Departmentadm[0];
            A592View_New_Encounter2view_NE_ENCType = VIEW_NEW_E2_A592View_New_Encounter2view_NE_ENCType[0];
            n592View_New_Encounter2view_NE_ENCType = VIEW_NEW_E2_n592View_New_Encounter2view_NE_ENCType[0];
            A591View_New_Encounter2view_NE_EncounterID = VIEW_NEW_E2_A591View_New_Encounter2view_NE_EncounterID[0];
            A594View_New_Encounter2view_NE_AdmitDate = VIEW_NEW_E2_A594View_New_Encounter2view_NE_AdmitDate[0];
            n594View_New_Encounter2view_NE_AdmitDate = VIEW_NEW_E2_n594View_New_Encounter2view_NE_AdmitDate[0];
            A40000GXC1 = DateTimeUtil.ResetTime( A594View_New_Encounter2view_NE_AdmitDate);
            /*
               INSERT RECORD ON TABLE GXA0075

            */
            AV2View_New_Encounter2view_NE_EncounterID = A591View_New_Encounter2view_NE_EncounterID;
            if ( VIEW_NEW_E2_n592View_New_Encounter2view_NE_ENCType[0] )
            {
               AV3View_New_Encounter2view_NE_ENCType = "";
               nV3View_New_Encounter2view_NE_ENCType = false;
               nV3View_New_Encounter2view_NE_ENCType = true;
            }
            else
            {
               AV3View_New_Encounter2view_NE_ENCType = A592View_New_Encounter2view_NE_ENCType;
               nV3View_New_Encounter2view_NE_ENCType = false;
            }
            if ( VIEW_NEW_E2_n593View_New_Encounter2view_NE_Departmentadm[0] )
            {
               AV4View_New_Encounter2view_NE_Departmentadm = "";
               nV4View_New_Encounter2view_NE_Departmentadm = false;
               nV4View_New_Encounter2view_NE_Departmentadm = true;
            }
            else
            {
               AV4View_New_Encounter2view_NE_Departmentadm = A593View_New_Encounter2view_NE_Departmentadm;
               nV4View_New_Encounter2view_NE_Departmentadm = false;
            }
            if ( VIEW_NEW_E2_n594View_New_Encounter2view_NE_AdmitDate[0] )
            {
               AV5View_New_Encounter2view_NE_AdmitDate = DateTime.MinValue;
               nV5View_New_Encounter2view_NE_AdmitDate = false;
               nV5View_New_Encounter2view_NE_AdmitDate = true;
            }
            else
            {
               AV5View_New_Encounter2view_NE_AdmitDate = A40000GXC1;
               nV5View_New_Encounter2view_NE_AdmitDate = false;
            }
            if ( VIEW_NEW_E2_n595View_New_Encounter2view_NE_Status[0] )
            {
               AV6View_New_Encounter2view_NE_Status = 0;
               nV6View_New_Encounter2view_NE_Status = false;
               nV6View_New_Encounter2view_NE_Status = true;
            }
            else
            {
               AV6View_New_Encounter2view_NE_Status = A595View_New_Encounter2view_NE_Status;
               nV6View_New_Encounter2view_NE_Status = false;
            }
            if ( VIEW_NEW_E2_n596View_New_Encounter2view_NE_IsRandRecheck[0] )
            {
               AV7View_New_Encounter2view_NE_IsRandRecheck = false;
               nV7View_New_Encounter2view_NE_IsRandRecheck = false;
               nV7View_New_Encounter2view_NE_IsRandRecheck = true;
            }
            else
            {
               AV7View_New_Encounter2view_NE_IsRandRecheck = (bool)(Convert.ToBoolean(A596View_New_Encounter2view_NE_IsRandRecheck));
               nV7View_New_Encounter2view_NE_IsRandRecheck = false;
            }
            if ( VIEW_NEW_E2_n597View_New_Encounter2view_NE_IsRandApprove[0] )
            {
               AV8View_New_Encounter2view_NE_IsRandApprove = false;
               nV8View_New_Encounter2view_NE_IsRandApprove = false;
               nV8View_New_Encounter2view_NE_IsRandApprove = true;
            }
            else
            {
               AV8View_New_Encounter2view_NE_IsRandApprove = (bool)(Convert.ToBoolean(A597View_New_Encounter2view_NE_IsRandApprove));
               nV8View_New_Encounter2view_NE_IsRandApprove = false;
            }
            if ( VIEW_NEW_E2_n598View_New_Encounter2view_NE_IsUpdate[0] )
            {
               AV9View_New_Encounter2view_NE_IsUpdate = false;
               nV9View_New_Encounter2view_NE_IsUpdate = false;
               nV9View_New_Encounter2view_NE_IsUpdate = true;
            }
            else
            {
               AV9View_New_Encounter2view_NE_IsUpdate = (bool)(Convert.ToBoolean(A598View_New_Encounter2view_NE_IsUpdate));
               nV9View_New_Encounter2view_NE_IsUpdate = false;
            }
            if ( VIEW_NEW_E2_n599View_New_Encounter2view_NE_TenantTenantCode[0] )
            {
               AV10View_New_Encounter2view_NE_TenantTenantCode = "";
               nV10View_New_Encounter2view_NE_TenantTenantCode = false;
               nV10View_New_Encounter2view_NE_TenantTenantCode = true;
            }
            else
            {
               AV10View_New_Encounter2view_NE_TenantTenantCode = A599View_New_Encounter2view_NE_TenantTenantCode;
               nV10View_New_Encounter2view_NE_TenantTenantCode = false;
            }
            if ( VIEW_NEW_E2_n600View_New_Encounter2view_NE_Information_ID[0] )
            {
               AV11View_New_Encounter2view_NE_Information_ID = 0;
               nV11View_New_Encounter2view_NE_Information_ID = false;
               nV11View_New_Encounter2view_NE_Information_ID = true;
            }
            else
            {
               AV11View_New_Encounter2view_NE_Information_ID = A600View_New_Encounter2view_NE_Information_ID;
               nV11View_New_Encounter2view_NE_Information_ID = false;
            }
            if ( VIEW_NEW_E2_n601View_New_Encounter2view_NE_Information_PatientNo[0] )
            {
               AV12View_New_Encounter2view_NE_Information_PatientNo = "";
               nV12View_New_Encounter2view_NE_Information_PatientNo = false;
               nV12View_New_Encounter2view_NE_Information_PatientNo = true;
            }
            else
            {
               AV12View_New_Encounter2view_NE_Information_PatientNo = A601View_New_Encounter2view_NE_Information_PatientNo;
               nV12View_New_Encounter2view_NE_Information_PatientNo = false;
            }
            /* Using cursor VIEW_NEW_E3 */
            pr_default.execute(1, new Object[] {AV2View_New_Encounter2view_NE_EncounterID, nV3View_New_Encounter2view_NE_ENCType, AV3View_New_Encounter2view_NE_ENCType, nV4View_New_Encounter2view_NE_Departmentadm, AV4View_New_Encounter2view_NE_Departmentadm, nV5View_New_Encounter2view_NE_AdmitDate, AV5View_New_Encounter2view_NE_AdmitDate, nV6View_New_Encounter2view_NE_Status, AV6View_New_Encounter2view_NE_Status, nV7View_New_Encounter2view_NE_IsRandRecheck, AV7View_New_Encounter2view_NE_IsRandRecheck, nV8View_New_Encounter2view_NE_IsRandApprove, AV8View_New_Encounter2view_NE_IsRandApprove, nV9View_New_Encounter2view_NE_IsUpdate, AV9View_New_Encounter2view_NE_IsUpdate, nV10View_New_Encounter2view_NE_TenantTenantCode, AV10View_New_Encounter2view_NE_TenantTenantCode, nV11View_New_Encounter2view_NE_Information_ID, AV11View_New_Encounter2view_NE_Information_ID, nV12View_New_Encounter2view_NE_Information_PatientNo, AV12View_New_Encounter2view_NE_Information_PatientNo});
            pr_default.close(1);
            dsDefault.SmartCacheProvider.SetUpdated("GXA0075") ;
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
         VIEW_NEW_E2_A601View_New_Encounter2view_NE_Information_PatientNo = new String[] {""} ;
         VIEW_NEW_E2_n601View_New_Encounter2view_NE_Information_PatientNo = new bool[] {false} ;
         VIEW_NEW_E2_A600View_New_Encounter2view_NE_Information_ID = new long[1] ;
         VIEW_NEW_E2_n600View_New_Encounter2view_NE_Information_ID = new bool[] {false} ;
         VIEW_NEW_E2_A599View_New_Encounter2view_NE_TenantTenantCode = new String[] {""} ;
         VIEW_NEW_E2_n599View_New_Encounter2view_NE_TenantTenantCode = new bool[] {false} ;
         VIEW_NEW_E2_A598View_New_Encounter2view_NE_IsUpdate = new short[1] ;
         VIEW_NEW_E2_n598View_New_Encounter2view_NE_IsUpdate = new bool[] {false} ;
         VIEW_NEW_E2_A597View_New_Encounter2view_NE_IsRandApprove = new short[1] ;
         VIEW_NEW_E2_n597View_New_Encounter2view_NE_IsRandApprove = new bool[] {false} ;
         VIEW_NEW_E2_A596View_New_Encounter2view_NE_IsRandRecheck = new short[1] ;
         VIEW_NEW_E2_n596View_New_Encounter2view_NE_IsRandRecheck = new bool[] {false} ;
         VIEW_NEW_E2_A595View_New_Encounter2view_NE_Status = new short[1] ;
         VIEW_NEW_E2_n595View_New_Encounter2view_NE_Status = new bool[] {false} ;
         VIEW_NEW_E2_A593View_New_Encounter2view_NE_Departmentadm = new String[] {""} ;
         VIEW_NEW_E2_n593View_New_Encounter2view_NE_Departmentadm = new bool[] {false} ;
         VIEW_NEW_E2_A592View_New_Encounter2view_NE_ENCType = new String[] {""} ;
         VIEW_NEW_E2_n592View_New_Encounter2view_NE_ENCType = new bool[] {false} ;
         VIEW_NEW_E2_A591View_New_Encounter2view_NE_EncounterID = new long[1] ;
         VIEW_NEW_E2_A594View_New_Encounter2view_NE_AdmitDate = new DateTime[] {DateTime.MinValue} ;
         VIEW_NEW_E2_n594View_New_Encounter2view_NE_AdmitDate = new bool[] {false} ;
         A601View_New_Encounter2view_NE_Information_PatientNo = "";
         A599View_New_Encounter2view_NE_TenantTenantCode = "";
         A593View_New_Encounter2view_NE_Departmentadm = "";
         A592View_New_Encounter2view_NE_ENCType = "";
         A594View_New_Encounter2view_NE_AdmitDate = (DateTime)(DateTime.MinValue);
         A40000GXC1 = DateTime.MinValue;
         AV3View_New_Encounter2view_NE_ENCType = "";
         AV4View_New_Encounter2view_NE_Departmentadm = "";
         AV5View_New_Encounter2view_NE_AdmitDate = DateTime.MinValue;
         AV10View_New_Encounter2view_NE_TenantTenantCode = "";
         AV12View_New_Encounter2view_NE_Information_PatientNo = "";
         Gx_emsg = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.view_new_encounterconversion__default(),
            new Object[][] {
                new Object[] {
               VIEW_NEW_E2_A601View_New_Encounter2view_NE_Information_PatientNo, VIEW_NEW_E2_n601View_New_Encounter2view_NE_Information_PatientNo, VIEW_NEW_E2_A600View_New_Encounter2view_NE_Information_ID, VIEW_NEW_E2_n600View_New_Encounter2view_NE_Information_ID, VIEW_NEW_E2_A599View_New_Encounter2view_NE_TenantTenantCode, VIEW_NEW_E2_n599View_New_Encounter2view_NE_TenantTenantCode, VIEW_NEW_E2_A598View_New_Encounter2view_NE_IsUpdate, VIEW_NEW_E2_n598View_New_Encounter2view_NE_IsUpdate, VIEW_NEW_E2_A597View_New_Encounter2view_NE_IsRandApprove, VIEW_NEW_E2_n597View_New_Encounter2view_NE_IsRandApprove,
               VIEW_NEW_E2_A596View_New_Encounter2view_NE_IsRandRecheck, VIEW_NEW_E2_n596View_New_Encounter2view_NE_IsRandRecheck, VIEW_NEW_E2_A595View_New_Encounter2view_NE_Status, VIEW_NEW_E2_n595View_New_Encounter2view_NE_Status, VIEW_NEW_E2_A593View_New_Encounter2view_NE_Departmentadm, VIEW_NEW_E2_n593View_New_Encounter2view_NE_Departmentadm, VIEW_NEW_E2_A592View_New_Encounter2view_NE_ENCType, VIEW_NEW_E2_n592View_New_Encounter2view_NE_ENCType, VIEW_NEW_E2_A591View_New_Encounter2view_NE_EncounterID, VIEW_NEW_E2_A594View_New_Encounter2view_NE_AdmitDate,
               VIEW_NEW_E2_n594View_New_Encounter2view_NE_AdmitDate
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short A598View_New_Encounter2view_NE_IsUpdate ;
      private short A597View_New_Encounter2view_NE_IsRandApprove ;
      private short A596View_New_Encounter2view_NE_IsRandRecheck ;
      private short A595View_New_Encounter2view_NE_Status ;
      private short AV6View_New_Encounter2view_NE_Status ;
      private int GIGXA0075 ;
      private long A600View_New_Encounter2view_NE_Information_ID ;
      private long A591View_New_Encounter2view_NE_EncounterID ;
      private long AV2View_New_Encounter2view_NE_EncounterID ;
      private long AV11View_New_Encounter2view_NE_Information_ID ;
      private String scmdbuf ;
      private String Gx_emsg ;
      private DateTime A594View_New_Encounter2view_NE_AdmitDate ;
      private DateTime A40000GXC1 ;
      private DateTime AV5View_New_Encounter2view_NE_AdmitDate ;
      private bool n601View_New_Encounter2view_NE_Information_PatientNo ;
      private bool n600View_New_Encounter2view_NE_Information_ID ;
      private bool n599View_New_Encounter2view_NE_TenantTenantCode ;
      private bool n598View_New_Encounter2view_NE_IsUpdate ;
      private bool n597View_New_Encounter2view_NE_IsRandApprove ;
      private bool n596View_New_Encounter2view_NE_IsRandRecheck ;
      private bool n595View_New_Encounter2view_NE_Status ;
      private bool n593View_New_Encounter2view_NE_Departmentadm ;
      private bool n592View_New_Encounter2view_NE_ENCType ;
      private bool n594View_New_Encounter2view_NE_AdmitDate ;
      private bool nV3View_New_Encounter2view_NE_ENCType ;
      private bool nV4View_New_Encounter2view_NE_Departmentadm ;
      private bool nV5View_New_Encounter2view_NE_AdmitDate ;
      private bool nV6View_New_Encounter2view_NE_Status ;
      private bool AV7View_New_Encounter2view_NE_IsRandRecheck ;
      private bool nV7View_New_Encounter2view_NE_IsRandRecheck ;
      private bool AV8View_New_Encounter2view_NE_IsRandApprove ;
      private bool nV8View_New_Encounter2view_NE_IsRandApprove ;
      private bool AV9View_New_Encounter2view_NE_IsUpdate ;
      private bool nV9View_New_Encounter2view_NE_IsUpdate ;
      private bool nV10View_New_Encounter2view_NE_TenantTenantCode ;
      private bool nV11View_New_Encounter2view_NE_Information_ID ;
      private bool nV12View_New_Encounter2view_NE_Information_PatientNo ;
      private String A601View_New_Encounter2view_NE_Information_PatientNo ;
      private String A599View_New_Encounter2view_NE_TenantTenantCode ;
      private String A593View_New_Encounter2view_NE_Departmentadm ;
      private String A592View_New_Encounter2view_NE_ENCType ;
      private String AV3View_New_Encounter2view_NE_ENCType ;
      private String AV4View_New_Encounter2view_NE_Departmentadm ;
      private String AV10View_New_Encounter2view_NE_TenantTenantCode ;
      private String AV12View_New_Encounter2view_NE_Information_PatientNo ;
      private IGxDataStore dsDataStore2 ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] VIEW_NEW_E2_A601View_New_Encounter2view_NE_Information_PatientNo ;
      private bool[] VIEW_NEW_E2_n601View_New_Encounter2view_NE_Information_PatientNo ;
      private long[] VIEW_NEW_E2_A600View_New_Encounter2view_NE_Information_ID ;
      private bool[] VIEW_NEW_E2_n600View_New_Encounter2view_NE_Information_ID ;
      private String[] VIEW_NEW_E2_A599View_New_Encounter2view_NE_TenantTenantCode ;
      private bool[] VIEW_NEW_E2_n599View_New_Encounter2view_NE_TenantTenantCode ;
      private short[] VIEW_NEW_E2_A598View_New_Encounter2view_NE_IsUpdate ;
      private bool[] VIEW_NEW_E2_n598View_New_Encounter2view_NE_IsUpdate ;
      private short[] VIEW_NEW_E2_A597View_New_Encounter2view_NE_IsRandApprove ;
      private bool[] VIEW_NEW_E2_n597View_New_Encounter2view_NE_IsRandApprove ;
      private short[] VIEW_NEW_E2_A596View_New_Encounter2view_NE_IsRandRecheck ;
      private bool[] VIEW_NEW_E2_n596View_New_Encounter2view_NE_IsRandRecheck ;
      private short[] VIEW_NEW_E2_A595View_New_Encounter2view_NE_Status ;
      private bool[] VIEW_NEW_E2_n595View_New_Encounter2view_NE_Status ;
      private String[] VIEW_NEW_E2_A593View_New_Encounter2view_NE_Departmentadm ;
      private bool[] VIEW_NEW_E2_n593View_New_Encounter2view_NE_Departmentadm ;
      private String[] VIEW_NEW_E2_A592View_New_Encounter2view_NE_ENCType ;
      private bool[] VIEW_NEW_E2_n592View_New_Encounter2view_NE_ENCType ;
      private long[] VIEW_NEW_E2_A591View_New_Encounter2view_NE_EncounterID ;
      private DateTime[] VIEW_NEW_E2_A594View_New_Encounter2view_NE_AdmitDate ;
      private bool[] VIEW_NEW_E2_n594View_New_Encounter2view_NE_AdmitDate ;
   }

   public class view_new_encounterconversion__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmVIEW_NEW_E2 ;
          prmVIEW_NEW_E2 = new Object[] {
          } ;
          Object[] prmVIEW_NEW_E3 ;
          prmVIEW_NEW_E3 = new Object[] {
          new Object[] {"@AV2View_New_Encounter2view_NE_EncounterID",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV3View_New_Encounter2view_NE_ENCType",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV4View_New_Encounter2view_NE_Departmentadm",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV5View_New_Encounter2view_NE_AdmitDate",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV6View_New_Encounter2view_NE_Status",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV7View_New_Encounter2view_NE_IsRandRecheck",SqlDbType.Bit,1,0} ,
          new Object[] {"@AV8View_New_Encounter2view_NE_IsRandApprove",SqlDbType.Bit,1,0} ,
          new Object[] {"@AV9View_New_Encounter2view_NE_IsUpdate",SqlDbType.Bit,1,0} ,
          new Object[] {"@AV10View_New_Encounter2view_NE_TenantTenantCode",SqlDbType.NVarChar,20,0} ,
          new Object[] {"@AV11View_New_Encounter2view_NE_Information_ID",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV12View_New_Encounter2view_NE_Information_PatientNo",SqlDbType.NVarChar,4000,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("VIEW_NEW_E2", "SELECT [View_New_Encounter2view_NE_Information_PatientNo], [View_New_Encounter2view_NE_Information_ID], [View_New_Encounter2view_NE_TenantTenantCode], [View_New_Encounter2view_NE_IsUpdate], [View_New_Encounter2view_NE_IsRandApprove], [View_New_Encounter2view_NE_IsRandRecheck], [View_New_Encounter2view_NE_Status], [View_New_Encounter2view_NE_Departmentadm], [View_New_Encounter2view_NE_ENCType], [View_New_Encounter2view_NE_EncounterID], [View_New_Encounter2view_NE_AdmitDate] FROM [View_New_Encounter] ORDER BY [View_New_Encounter2view_NE_EncounterID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmVIEW_NEW_E2,100,0,true,false )
             ,new CursorDef("VIEW_NEW_E3", "INSERT INTO [GXA0075]([View_New_Encounter2view_NE_EncounterID], [View_New_Encounter2view_NE_ENCType], [View_New_Encounter2view_NE_Departmentadm], [View_New_Encounter2view_NE_AdmitDate], [View_New_Encounter2view_NE_Status], [View_New_Encounter2view_NE_IsRandRecheck], [View_New_Encounter2view_NE_IsRandApprove], [View_New_Encounter2view_NE_IsUpdate], [View_New_Encounter2view_NE_TenantTenantCode], [View_New_Encounter2view_NE_Information_ID], [View_New_Encounter2view_NE_Information_PatientNo]) VALUES(@AV2View_New_Encounter2view_NE_EncounterID, @AV3View_New_Encounter2view_NE_ENCType, @AV4View_New_Encounter2view_NE_Departmentadm, @AV5View_New_Encounter2view_NE_AdmitDate, @AV6View_New_Encounter2view_NE_Status, @AV7View_New_Encounter2view_NE_IsRandRecheck, @AV8View_New_Encounter2view_NE_IsRandApprove, @AV9View_New_Encounter2view_NE_IsUpdate, @AV10View_New_Encounter2view_NE_TenantTenantCode, @AV11View_New_Encounter2view_NE_Information_ID, @AV12View_New_Encounter2view_NE_Information_PatientNo)", GxErrorMask.GX_NOMASK,prmVIEW_NEW_E3)
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
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((long[]) buf[2])[0] = rslt.getLong(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((short[]) buf[6])[0] = rslt.getShort(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((short[]) buf[8])[0] = rslt.getShort(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((short[]) buf[10])[0] = rslt.getShort(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((short[]) buf[12])[0] = rslt.getShort(7) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(7);
                ((String[]) buf[14])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(8);
                ((String[]) buf[16])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(9);
                ((long[]) buf[18])[0] = rslt.getLong(10) ;
                ((DateTime[]) buf[19])[0] = rslt.getGXDateTime(11) ;
                ((bool[]) buf[20])[0] = rslt.wasNull(11);
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
                if ( (bool)parms[1] )
                {
                   stmt.setNull( 2 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(2, (String)parms[2]);
                }
                if ( (bool)parms[3] )
                {
                   stmt.setNull( 3 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(3, (String)parms[4]);
                }
                if ( (bool)parms[5] )
                {
                   stmt.setNull( 4 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(4, (DateTime)parms[6]);
                }
                if ( (bool)parms[7] )
                {
                   stmt.setNull( 5 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(5, (short)parms[8]);
                }
                if ( (bool)parms[9] )
                {
                   stmt.setNull( 6 , SqlDbType.Bit );
                }
                else
                {
                   stmt.SetParameter(6, (bool)parms[10]);
                }
                if ( (bool)parms[11] )
                {
                   stmt.setNull( 7 , SqlDbType.Bit );
                }
                else
                {
                   stmt.SetParameter(7, (bool)parms[12]);
                }
                if ( (bool)parms[13] )
                {
                   stmt.setNull( 8 , SqlDbType.Bit );
                }
                else
                {
                   stmt.SetParameter(8, (bool)parms[14]);
                }
                if ( (bool)parms[15] )
                {
                   stmt.setNull( 9 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(9, (String)parms[16]);
                }
                if ( (bool)parms[17] )
                {
                   stmt.setNull( 10 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(10, (long)parms[18]);
                }
                if ( (bool)parms[19] )
                {
                   stmt.setNull( 11 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(11, (String)parms[20]);
                }
                return;
       }
    }

 }

}
