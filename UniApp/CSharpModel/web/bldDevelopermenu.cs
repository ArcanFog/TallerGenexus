using System;
using GeneXus.Builder;
using System.IO;
public class bldDevelopermenu : GxBaseBuilder
{
   string cs_path = "." ;
   public bldDevelopermenu( ) : base()
   {
   }

   public override int BeforeCompile( )
   {
      return 0 ;
   }

   public override int AfterCompile( )
   {
      int ErrCode ;
      ErrCode = 0;
      if ( ! File.Exists(@"bin\client.exe.config") || checkTime(@"bin\client.exe.config",cs_path + @"\client.exe.config") )
      {
         File.Copy( cs_path + @"\client.exe.config", @"bin\client.exe.config", true);
      }
      return ErrCode ;
   }

   static public int Main( string[] args )
   {
      bldDevelopermenu x = new bldDevelopermenu() ;
      x.SetMainSourceFile( "bldDevelopermenu.cs");
      x.LoadVariables( args);
      return x.CompileAll( );
   }

   public override ItemCollection GetSortedBuildList( )
   {
      ItemCollection sc = new ItemCollection() ;
      sc.Add( @"bin\GeneXus.Programs.Common.dll", cs_path + @"\genexus.programs.common.rsp");
      return sc ;
   }

   public override TargetCollection GetRuntimeBuildList( )
   {
      TargetCollection sc = new TargetCollection() ;
      sc.Add( @"adocentesporasignatura", "dll");
      sc.Add( @"adocentesporasignatura", "dll");
      sc.Add( @"acarreraasignaturalista", "dll");
      sc.Add( @"acarreraasignaturalista", "dll");
      sc.Add( @"aexamenes", "dll");
      sc.Add( @"aexamenes", "dll");
      sc.Add( @"appmasterpage", "dll");
      sc.Add( @"recentlinks", "dll");
      sc.Add( @"promptmasterpage", "dll");
      sc.Add( @"rwdmasterpage", "dll");
      sc.Add( @"rwdrecentlinks", "dll");
      sc.Add( @"rwdpromptmasterpage", "dll");
      sc.Add( @"home", "dll");
      sc.Add( @"home", "dll");
      sc.Add( @"notauthorized", "dll");
      sc.Add( @"tabbedview", "dll");
      sc.Add( @"wwasignatura", "dll");
      sc.Add( @"asignaturageneral", "dll");
      sc.Add( @"asignaturaasignaturawc", "dll");
      sc.Add( @"asignaturadocentewc", "dll");
      sc.Add( @"viewasignatura", "dll");
      sc.Add( @"viewcarrera", "dll");
      sc.Add( @"wwcarrera", "dll");
      sc.Add( @"carrerageneral", "dll");
      sc.Add( @"carreraasignaturawc", "dll");
      sc.Add( @"carreraestudiantewc", "dll");
      sc.Add( @"carreraexamenwc", "dll");
      sc.Add( @"viewdocente", "dll");
      sc.Add( @"wwdocente", "dll");
      sc.Add( @"docentegeneral", "dll");
      sc.Add( @"viewestudiante", "dll");
      sc.Add( @"wwestudiante", "dll");
      sc.Add( @"estudiantegeneral", "dll");
      sc.Add( @"estudianteestudiiantewc", "dll");
      sc.Add( @"viewcertificado", "dll");
      sc.Add( @"wwcertificado", "dll");
      sc.Add( @"certificadogeneral", "dll");
      sc.Add( @"viewexamen", "dll");
      sc.Add( @"wwexamen", "dll");
      sc.Add( @"examengeneral", "dll");
      sc.Add( @"examenestudiiantewc", "dll");
      sc.Add( @"gx0081", "dll");
      sc.Add( @"gx0020", "dll");
      sc.Add( @"gx0070", "dll");
      sc.Add( @"gx0091", "dll");
      sc.Add( @"gx0050", "dll");
      sc.Add( @"gx00a0", "dll");
      sc.Add( @"examenporfecha", "dll");
      sc.Add( @"carrera", "dll");
      sc.Add( @"asignatura", "dll");
      sc.Add( @"docente", "dll");
      sc.Add( @"estudiante", "dll");
      sc.Add( @"certificado", "dll");
      sc.Add( @"examen", "dll");
      return sc ;
   }

   public override ItemCollection GetResBuildList( )
   {
      ItemCollection sc = new ItemCollection() ;
      sc.Add( @"bin\messages.eng.dll", cs_path + @"\messages.eng.txt");
      return sc ;
   }

   public override bool ToBuild( String obj )
   {
      if (checkTime(obj, cs_path + @"\bin\GxClasses.dll" ))
         return true;
      if ( obj == @"bin\GeneXus.Programs.Common.dll" )
      {
         if (checkTime(obj, cs_path + @"\GxWebStd.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\SoapParm.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GxObjectCollection.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GxFullTextSearchReindexer.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GxModelInfoProvider.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\genexus.programs.sdt.rsp" ))
            return true;
         if (checkTime(obj, cs_path + @"\gxdomainpage.cs" ))
            return true;
      }
      if ( obj == @"bin\messages.eng.dll" )
      {
         if (checkTime(obj, cs_path + @"\messages.eng.txt" ))
            return true;
      }
      return false ;
   }

}

