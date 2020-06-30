/*
               File: ZUtil_CalculateEntity
        Description: 计算病种人数数量的方法
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:35:40.80
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
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class zutil_calculateentity : GXProcedure
   {
      public zutil_calculateentity( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public zutil_calculateentity( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( out String aP0_oContent )
      {
         this.AV8oContent = "" ;
         initialize();
         executePrivate();
         aP0_oContent=this.AV8oContent;
      }

      public String executeUdp( )
      {
         this.AV8oContent = "" ;
         initialize();
         executePrivate();
         aP0_oContent=this.AV8oContent;
         return AV8oContent ;
      }

      public void executeSubmit( out String aP0_oContent )
      {
         zutil_calculateentity objzutil_calculateentity;
         objzutil_calculateentity = new zutil_calculateentity();
         objzutil_calculateentity.AV8oContent = "" ;
         objzutil_calculateentity.context.SetSubmitInitialConfig(context);
         objzutil_calculateentity.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objzutil_calculateentity);
         aP0_oContent=this.AV8oContent;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((zutil_calculateentity)stateInfo).executePrivate();
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
         AV10SDT_EntityCount.Clear();
         /* Using cursor P003Q2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A366DataPackage = P003Q2_A366DataPackage[0];
            if ( String.IsNullOrEmpty(StringUtil.RTrim( A366DataPackage)) || P003Q2_n366DataPackage[0] )
            {
            }
            else
            {
               AV11SDT_EntityCountItem = new SdtSDT_EntityCount(context);
               AV11SDT_EntityCountItem.gxTpr_Entityname = StringUtil.Trim( A366DataPackage);
               AV10SDT_EntityCount.Add(AV11SDT_EntityCountItem, 0);
            }
            pr_default.readNext(0);
         }
         pr_default.close(0);
         AV14tNewSDT_EntityCount.Clear();
         AV20GXV1 = 1;
         while ( AV20GXV1 <= AV10SDT_EntityCount.Count )
         {
            AV12SDT_EntityCountItemCheck = ((SdtSDT_EntityCount)AV10SDT_EntityCount.Item(AV20GXV1));
            AV12SDT_EntityCountItemCheck.gxTpr_Value = 0;
            /* Optimized group. */
            /* Using cursor P003Q3 */
            pr_default.execute(1, new Object[] {AV12SDT_EntityCountItemCheck.gxTpr_Entityname});
            aggopt0 = P003Q3_Aaggopt0[0];
            pr_default.close(1);
            AV12SDT_EntityCountItemCheck.gxTpr_Value = (long)(AV12SDT_EntityCountItemCheck.gxTpr_Value+aggopt0*1);
            /* End optimized group. */
            AV14tNewSDT_EntityCount.Add(AV12SDT_EntityCountItemCheck, 0);
            AV20GXV1 = (int)(AV20GXV1+1);
         }
         AV8oContent = AV14tNewSDT_EntityCount.ToJSonString(false);
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
         AV10SDT_EntityCount = new GXBaseCollection<SdtSDT_EntityCount>( context, "SDT_EntityCount", "DataAnalysisPlatform");
         scmdbuf = "";
         P003Q2_A366DataPackage = new String[] {""} ;
         A366DataPackage = "";
         P003Q2_n366DataPackage = new bool[] {false} ;
         AV11SDT_EntityCountItem = new SdtSDT_EntityCount(context);
         AV14tNewSDT_EntityCount = new GXBaseCollection<SdtSDT_EntityCount>( context, "SDT_EntityCount", "DataAnalysisPlatform");
         AV12SDT_EntityCountItemCheck = new SdtSDT_EntityCount(context);
         P003Q3_Aaggopt0 = new long[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.zutil_calculateentity__default(),
            new Object[][] {
                new Object[] {
               P003Q2_A366DataPackage
               }
               , new Object[] {
               P003Q3_Aaggopt0
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private int AV20GXV1 ;
      private long aggopt0 ;
      private String scmdbuf ;
      private String AV8oContent ;
      private String A366DataPackage ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P003Q2_A366DataPackage ;
      private bool[] P003Q2_n366DataPackage ;
      private long[] P003Q3_Aaggopt0 ;
      private String aP0_oContent ;
      private GXBaseCollection<SdtSDT_EntityCount> AV10SDT_EntityCount ;
      private GXBaseCollection<SdtSDT_EntityCount> AV14tNewSDT_EntityCount ;
      private SdtSDT_EntityCount AV11SDT_EntityCountItem ;
      private SdtSDT_EntityCount AV12SDT_EntityCountItemCheck ;
   }

   public class zutil_calculateentity__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP003Q2 ;
          prmP003Q2 = new Object[] {
          } ;
          Object[] prmP003Q3 ;
          prmP003Q3 = new Object[] {
          new Object[] {"@AV12SDT__1Entityname",SqlDbType.NVarChar,40,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P003Q2", "SELECT DISTINCT [DataPackage] FROM [BR_PatientReEntity] WITH (NOLOCK) ORDER BY [DataPackage] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP003Q2,100,0,false,false )
             ,new CursorDef("P003Q3", "SELECT COUNT(*) FROM [BR_PatientReEntity] WITH (NOLOCK) WHERE RTRIM(LTRIM([DataPackage])) = @AV12SDT__1Entityname ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP003Q3,1,0,true,false )
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
                return;
             case 1 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
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
                stmt.SetParameter(1, (String)parms[0]);
                return;
       }
    }

 }

}
