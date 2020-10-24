/*
               File: AsignaturaConversion
        Description: Conversion for table Asignatura
             Author: GeneXus C# Generator version 16_0_1-129648
       Generated on: 10/17/2020 11:15:15.86
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
   public class asignaturaconversion : GXProcedure
   {
      public asignaturaconversion( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public asignaturaconversion( IGxContext context )
      {
         this.context = context;
         IsMain = false;
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
         asignaturaconversion objasignaturaconversion;
         objasignaturaconversion = new asignaturaconversion();
         objasignaturaconversion.context.SetSubmitInitialConfig(context);
         objasignaturaconversion.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objasignaturaconversion);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((asignaturaconversion)stateInfo).executePrivate();
         }
         catch ( Exception e )
         {
            GXUtil.SaveToEventLog( "Design", e);
            throw e ;
         }
      }

      void executePrivate( )
      {
         /* GeneXus formulas */
         /* Output device settings */
         /* Optimized copy (Insert w/Subselect). */
         /* Using cursor ASIGNATURA2 */
         pr_default.execute(0);
         pr_default.close(0);
         dsDefault.SmartCacheProvider.SetUpdated("Asignatura") ;
         if ( (pr_default.getStatus(0) == 1) )
         {
            context.Gx_err = 1;
            Gx_emsg = (String)(GXResourceManager.GetMessage("GXM_noupdate"));
         }
         else
         {
            context.Gx_err = 0;
            Gx_emsg = "";
         }
         /* End optimized group. */
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
         Gx_emsg = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.asignaturaconversion__default(),
            new Object[][] {
                new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private String Gx_emsg ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
   }

   public class asignaturaconversion__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new UpdateCursor(def[0])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmASIGNATURA2 ;
          prmASIGNATURA2 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("ASIGNATURA2", "INSERT INTO [GXA0010]([AsignaturaId], [AsignaturaNombre], [AsignaturaSemestre]) SELECT [AsignaturaId], [AsignaturaNombre], [AsignaturaSemestre]  FROM [Asignatura]", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmASIGNATURA2)
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
