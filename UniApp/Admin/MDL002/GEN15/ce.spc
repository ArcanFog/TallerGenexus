spec_i([ ce,0,'Table Manager',1,2,reo ]).
 
 
 
new_tables(5,pk,[ 'EstudianteConversion','Estudiante',[ 15,18,19,40000,20,8 ],'GXA0005',[],[],[ [ 15,upd ] ],5 ]).
new_tables(7,pk,[ 'ExamenConversion','Examen',[ 17,26,22,24 ],'GXA0007',[],[],[ [ 17,upd ] ],7 ]).
 
conv_tables_i(7,[ [ 7 ] ]).
conv_tables_i(5,[ [ 5 ] ]).
 
table_exists_i(7,7,'Examen').
table_exists_i(5,5,'Estudiante').
 
nav_view_i(2000,[ 17,26,22,24 ],[ 17,26,22,24 ],[],[ [ 2000,[] ] ],[ [ [ 7,17 ],[ 7,26 ],[ 7,22 ],[ 7,24 ] ],n,[ [ 7,many ] ],[],[],[ none ],[],[],[] ]).
nav_view_i(2001,[ 15,18,19,40000,20,8 ],[ 15,18,19,40000,20,8 ],[],[ [ 2001,[] ] ],[ [ [ 5,15 ],[ 5,18 ],[ 5,19 ],[ 5,40000 ],[ 5,20 ],[ 5,8 ] ],n,[ [ 5,many ] ],[],[],[ none ],[],[],[] ]).
 
att_map_i(7,17,17).
att_map_i(7,26,26).
att_map_i(7,22,22).
att_map_i(7,24,24).
att_map_i(5,15,15).
att_map_i(5,18,18).
att_map_i(5,19,19).
att_map_i(5,40000,40000).
att_map_i(5,20,20).
att_map_i(5,8,8).
 
lv_i(2,2000,7).
lv_i(2,2001,5).
 
 
 
reorg_upd_i(7,[ 2000 ]).
reorg_upd_i(5,[ 2001 ]).
 
 
 
 
 
 
att_prop_i(1,15,'ExternalName','EstudianteId',d).
att_prop_i(1,15,'ExternalNamespace','UniApp',d).
att_prop_i(1,15,'EmptyAsNull','Yes',d).
att_prop_i(1,15,idBasedOn,'',d).
att_prop_i(1,15,'AUTONUMBER','-1',v).
att_prop_i(1,15,'AUTONUMBER_START','1',d).
att_prop_i(1,15,'AUTONUMBER_STEP','1',d).
att_prop_i(1,15,'AUTONUMBER_FORREPLICATION','-1',d).
att_prop_i(1,15,'ATT_INITIAL_VALUE','',d).
att_prop_i(1,15,'AttRegEx','',d).
att_prop_i(1,15,'AttValidationFailedMsg','',d).
att_prop_i(1,15,'FullName','EstudianteId',v).
att_prop_i(2,15,'ExternalName','EstudianteId',d).
att_prop_i(2,15,'ExternalNamespace','UniApp',d).
att_prop_i(2,15,'EmptyAsNull','Yes',d).
att_prop_i(2,15,idBasedOn,'',d).
att_prop_i(2,15,'AUTONUMBER','0',d).
att_prop_i(2,15,'ATT_INITIAL_VALUE','',d).
att_prop_i(2,15,'AttRegEx','',d).
att_prop_i(2,15,'AttValidationFailedMsg','',d).
att_prop_i(2,15,'FullName','EstudianteId',v).
att_prop_i(1,18,'ExternalName','EstudianteNombre',d).
att_prop_i(1,18,'ExternalNamespace','UniApp',d).
att_prop_i(1,18,'EmptyAsNull','Yes',d).
att_prop_i(1,18,idBasedOn,'',d).
att_prop_i(1,18,'ATT_INITIAL_VALUE','',d).
att_prop_i(1,18,'DB_NLS_SUPPORT','No',d).
att_prop_i(1,18,'AttRegEx','',d).
att_prop_i(1,18,'AttValidationFailedMsg','',d).
att_prop_i(1,18,'FullName','EstudianteNombre',v).
att_prop_i(2,18,'ExternalName','EstudianteNombre',d).
att_prop_i(2,18,'ExternalNamespace','UniApp',d).
att_prop_i(2,18,'EmptyAsNull','Yes',d).
att_prop_i(2,18,idBasedOn,'',d).
att_prop_i(2,18,'ATT_INITIAL_VALUE','',d).
att_prop_i(2,18,'DB_NLS_SUPPORT','No',d).
att_prop_i(2,18,'AttRegEx','',d).
att_prop_i(2,18,'AttValidationFailedMsg','',d).
att_prop_i(2,18,'FullName','EstudianteNombre',v).
att_prop_i(1,19,'ExternalName','EstudianteFoto',d).
att_prop_i(1,19,'ExternalNamespace','UniApp',d).
att_prop_i(1,19,'EmptyAsNull','Yes',d).
att_prop_i(1,19,'ExternalStorage','-1',d).
att_prop_i(1,19,idBasedOn,'',d).
att_prop_i(1,19,'ATT_INITIAL_VALUE','',d).
att_prop_i(1,19,'AttRegEx','',d).
att_prop_i(1,19,'AttValidationFailedMsg','',d).
att_prop_i(1,19,'FullName','EstudianteFoto',v).
att_prop_i(2,19,'ExternalName','EstudianteFoto',d).
att_prop_i(2,19,'ExternalNamespace','UniApp',d).
att_prop_i(2,19,'EmptyAsNull','Yes',d).
att_prop_i(2,19,'ExternalStorage','-1',d).
att_prop_i(2,19,idBasedOn,'',d).
att_prop_i(2,19,'ATT_INITIAL_VALUE','',d).
att_prop_i(2,19,'AttRegEx','',d).
att_prop_i(2,19,'AttValidationFailedMsg','',d).
att_prop_i(2,19,'FullName','EstudianteFoto',v).
att_prop_i(1,20,'ExternalName','EstudianteIngreso',d).
att_prop_i(1,20,'ExternalNamespace','UniApp',d).
att_prop_i(1,20,'EmptyAsNull','Yes',d).
att_prop_i(1,20,idBasedOn,'',d).
att_prop_i(1,20,'ATT_INITIAL_VALUE','',d).
att_prop_i(1,20,'AttRegEx','',d).
att_prop_i(1,20,'AttValidationFailedMsg','',d).
att_prop_i(1,20,idDATEFORMAT,idDATEFORMAT_SHORT,d).
att_prop_i(1,20,'FullName','EstudianteIngreso',v).
att_prop_i(2,20,'ExternalName','EstudianteIngreso',d).
att_prop_i(2,20,'ExternalNamespace','UniApp',d).
att_prop_i(2,20,'EmptyAsNull','Yes',d).
att_prop_i(2,20,idBasedOn,'',d).
att_prop_i(2,20,'ATT_INITIAL_VALUE','',d).
att_prop_i(2,20,'AttRegEx','',d).
att_prop_i(2,20,'AttValidationFailedMsg','',d).
att_prop_i(2,20,idDATEFORMAT,idDATEFORMAT_SHORT,d).
att_prop_i(2,20,'FullName','EstudianteIngreso',v).
att_prop_i(1,8,'ExternalName','CarreraId',d).
att_prop_i(1,8,'ExternalNamespace','UniApp',d).
att_prop_i(1,8,'EmptyAsNull','Yes',d).
att_prop_i(1,8,idBasedOn,'',d).
att_prop_i(1,8,'AUTONUMBER','-1',v).
att_prop_i(1,8,'AUTONUMBER_START','1',d).
att_prop_i(1,8,'AUTONUMBER_STEP','1',d).
att_prop_i(1,8,'AUTONUMBER_FORREPLICATION','-1',d).
att_prop_i(1,8,'ATT_INITIAL_VALUE','',d).
att_prop_i(1,8,'AttRegEx','',d).
att_prop_i(1,8,'AttValidationFailedMsg','',d).
att_prop_i(1,8,'FullName','CarreraId',v).
att_prop_i(2,8,'ExternalName','CarreraId',d).
att_prop_i(2,8,'ExternalNamespace','UniApp',d).
att_prop_i(2,8,'EmptyAsNull','Yes',d).
att_prop_i(2,8,idBasedOn,'',d).
att_prop_i(2,8,'AUTONUMBER','-1',v).
att_prop_i(2,8,'AUTONUMBER_START','1',d).
att_prop_i(2,8,'AUTONUMBER_STEP','1',d).
att_prop_i(2,8,'AUTONUMBER_FORREPLICATION','-1',d).
att_prop_i(2,8,'ATT_INITIAL_VALUE','',d).
att_prop_i(2,8,'AttRegEx','',d).
att_prop_i(2,8,'AttValidationFailedMsg','',d).
att_prop_i(2,8,'FullName','CarreraId',v).
att_prop_i(2,40000,'ExternalName','',d).
att_prop_i(2,40000,'ExternalNamespace','',d).
att_prop_i(2,40000,'EmptyAsNull','Yes',d).
att_prop_i(2,40000,idBasedOn,'',d).
att_prop_i(2,40000,'AUTONUMBER','0',d).
att_prop_i(2,40000,'ATT_INITIAL_VALUE','',d).
att_prop_i(2,40000,'AttRegEx','',d).
att_prop_i(2,40000,'AttValidationFailedMsg','',d).
att_prop_i(2,40000,'FullName','',v).
att_prop_i(1,17,'ExternalName','ExamenId',d).
att_prop_i(1,17,'ExternalNamespace','UniApp',d).
att_prop_i(1,17,'EmptyAsNull','Yes',d).
att_prop_i(1,17,idBasedOn,'',d).
att_prop_i(1,17,'AUTONUMBER','-1',v).
att_prop_i(1,17,'AUTONUMBER_START','1',d).
att_prop_i(1,17,'AUTONUMBER_STEP','1',d).
att_prop_i(1,17,'AUTONUMBER_FORREPLICATION','-1',d).
att_prop_i(1,17,'ATT_INITIAL_VALUE','',d).
att_prop_i(1,17,'AttRegEx','',d).
att_prop_i(1,17,'AttValidationFailedMsg','',d).
att_prop_i(1,17,'FullName','ExamenId',v).
att_prop_i(1,26,'ExternalName','ExamenFecha',d).
att_prop_i(1,26,'ExternalNamespace','UniApp',d).
att_prop_i(1,26,'EmptyAsNull','Yes',d).
att_prop_i(1,26,idBasedOn,'',d).
att_prop_i(1,26,'ATT_INITIAL_VALUE','',d).
att_prop_i(1,26,'AttRegEx','',d).
att_prop_i(1,26,'AttValidationFailedMsg','',d).
att_prop_i(1,26,idDATEFORMAT,idDATEFORMAT_SHORT,d).
att_prop_i(1,26,'FullName','ExamenFecha',v).
att_prop_i(1,22,'ExternalName','ExamenCarrAsigCarreraId',d).
att_prop_i(1,22,'ExternalNamespace','UniApp',d).
att_prop_i(1,22,'EmptyAsNull','Yes',v).
att_prop_i(1,22,idBasedOn,'',d).
att_prop_i(1,22,'AUTONUMBER','-1',d).
att_prop_i(1,22,'AUTONUMBER_START','1',d).
att_prop_i(1,22,'AUTONUMBER_STEP','1',d).
att_prop_i(1,22,'AUTONUMBER_FORREPLICATION','-1',d).
att_prop_i(1,22,'ATT_INITIAL_VALUE','',d).
att_prop_i(1,22,'AttRegEx','',d).
att_prop_i(1,22,'AttValidationFailedMsg','',d).
att_prop_i(1,22,'FullName','ExamenCarrAsigCarreraId',v).
att_prop_i(1,24,'ExternalName','ExamenCarrAsigAsignaturaId',d).
att_prop_i(1,24,'ExternalNamespace','UniApp',d).
att_prop_i(1,24,'EmptyAsNull','Yes',v).
att_prop_i(1,24,idBasedOn,'',d).
att_prop_i(1,24,'AUTONUMBER','-1',d).
att_prop_i(1,24,'AUTONUMBER_START','1',d).
att_prop_i(1,24,'AUTONUMBER_STEP','1',d).
att_prop_i(1,24,'AUTONUMBER_FORREPLICATION','-1',d).
att_prop_i(1,24,'ATT_INITIAL_VALUE','',d).
att_prop_i(1,24,'AttRegEx','',d).
att_prop_i(1,24,'AttValidationFailedMsg','',d).
att_prop_i(1,24,'FullName','ExamenCarrAsigAsignaturaId',v).
att_prop_i(2,17,'ExternalName','ExamenId',d).
att_prop_i(2,17,'ExternalNamespace','UniApp',d).
att_prop_i(2,17,'EmptyAsNull','Yes',d).
att_prop_i(2,17,idBasedOn,'',d).
att_prop_i(2,17,'AUTONUMBER','0',d).
att_prop_i(2,17,'ATT_INITIAL_VALUE','',d).
att_prop_i(2,17,'AttRegEx','',d).
att_prop_i(2,17,'AttValidationFailedMsg','',d).
att_prop_i(2,17,'FullName','ExamenId',v).
att_prop_i(2,26,'ExternalName','ExamenFecha',d).
att_prop_i(2,26,'ExternalNamespace','UniApp',d).
att_prop_i(2,26,'EmptyAsNull','Yes',d).
att_prop_i(2,26,idBasedOn,'',d).
att_prop_i(2,26,'ATT_INITIAL_VALUE','',d).
att_prop_i(2,26,'AttRegEx','',d).
att_prop_i(2,26,'AttValidationFailedMsg','',d).
att_prop_i(2,26,idDATEFORMAT,idDATEFORMAT_SHORT,d).
att_prop_i(2,26,'FullName','ExamenFecha',v).
att_prop_i(2,22,'ExternalName','ExamenCarrAsigCarreraId',d).
att_prop_i(2,22,'ExternalNamespace','UniApp',d).
att_prop_i(2,22,'EmptyAsNull','Yes',v).
att_prop_i(2,22,idBasedOn,'',d).
att_prop_i(2,22,'AUTONUMBER','-1',d).
att_prop_i(2,22,'AUTONUMBER_START','1',d).
att_prop_i(2,22,'AUTONUMBER_STEP','1',d).
att_prop_i(2,22,'AUTONUMBER_FORREPLICATION','-1',d).
att_prop_i(2,22,'ATT_INITIAL_VALUE','',d).
att_prop_i(2,22,'AttRegEx','',d).
att_prop_i(2,22,'AttValidationFailedMsg','',d).
att_prop_i(2,22,'FullName','ExamenCarrAsigCarreraId',v).
att_prop_i(2,24,'ExternalName','ExamenCarrAsigAsignaturaId',d).
att_prop_i(2,24,'ExternalNamespace','UniApp',d).
att_prop_i(2,24,'EmptyAsNull','Yes',v).
att_prop_i(2,24,idBasedOn,'',d).
att_prop_i(2,24,'AUTONUMBER','-1',d).
att_prop_i(2,24,'AUTONUMBER_START','1',d).
att_prop_i(2,24,'AUTONUMBER_STEP','1',d).
att_prop_i(2,24,'AUTONUMBER_FORREPLICATION','-1',d).
att_prop_i(2,24,'ATT_INITIAL_VALUE','',d).
att_prop_i(2,24,'AttRegEx','',d).
att_prop_i(2,24,'AttValidationFailedMsg','',d).
att_prop_i(2,24,'FullName','ExamenCarrAsigAsignaturaId',v).
 
tbl_prop_i(1,5,'AllDirSuper',[ [ 2,[ 8 ] ] ],v).
tbl_prop_i(1,5,'DirSuper',[ [ 2,[ 8 ] ] ],v).
tbl_prop_i(1,5,'DirSubor',[ [ 9,[ 15 ] ] ],v).
tbl_prop_i(2,5,'AllDirSuper',[ [ 2,[ 8 ] ] ],v).
tbl_prop_i(2,5,'DirSuper',[ [ 2,[ 8 ] ] ],v).
tbl_prop_i(2,5,'DirSubor',[ [ 9,[ 15 ] ] ],v).
tbl_prop_i(1,9,'AllDirSuper',[ [ 5,[ 15 ] ],[ 7,[ 17 ] ] ],v).
tbl_prop_i(1,9,'DirSuper',[ [ 5,[ 15 ] ],[ 7,[ 17 ] ] ],v).
tbl_prop_i(1,9,'DirSubor',[ [ 6,[ 17,15 ] ] ],v).
tbl_prop_i(2,9,'AllDirSuper',[ [ 5,[ 15 ] ],[ 7,[ 17 ] ] ],v).
tbl_prop_i(2,9,'DirSuper',[ [ 5,[ 15 ] ],[ 7,[ 17 ] ] ],v).
tbl_prop_i(2,9,'DirSubor',[ [ 6,[ 17,15 ] ] ],v).
tbl_prop_i(1,7,'AllDirSuper',[ [ 515,[ 22,24 ] ] ],v).
tbl_prop_i(1,7,'DirSuper',[ [ 515,[ 22,24 ] ] ],v).
tbl_prop_i(1,7,'DirSubor',[ [ 9,[ 17 ] ] ],v).
tbl_prop_i(2,7,'AllDirSuper',[ [ 515,[ 22,24 ] ] ],v).
tbl_prop_i(2,7,'DirSuper',[ [ 515,[ 22,24 ] ] ],v).
tbl_prop_i(2,7,'DirSubor',[ [ 9,[ 17 ] ] ],v).
 
tbl_att_prop_i(1,5,15,'AllowNulls',n).
tbl_att_prop_i(1,5,15,'AUTONUMBER',y).
tbl_att_prop_i(2,5,15,'AllowNulls',n).
tbl_att_prop_i(2,'GXA0005','T.EstudianteId','AllowNulls',n).
tbl_att_prop_i(2,'GXA0005','T.EstudianteId','AUTONUMBER',y).
tbl_att_prop_i(2,5,18,'AllowNulls',n).
tbl_att_prop_i(1,5,18,'AllowNulls',n).
tbl_att_prop_i(2,'GXA0005','T.EstudianteNombre','AllowNulls',n).
tbl_att_prop_i(2,5,19,'AllowNulls',n).
tbl_att_prop_i(1,5,19,'AllowNulls',n).
tbl_att_prop_i(2,'GXA0005','T.EstudianteFoto','AllowNulls',n).
tbl_att_prop_i(2,5,40000,'AllowNulls',n).
tbl_att_prop_i(1,5,40000,'AllowNulls',n).
tbl_att_prop_i(2,'GXA0005','T.EstudianteFoto_GXI','AllowNulls',n).
tbl_att_prop_i(2,5,20,'AllowNulls',n).
tbl_att_prop_i(1,5,20,'AllowNulls',n).
tbl_att_prop_i(2,'GXA0005','T.EstudianteIngreso','AllowNulls',n).
tbl_att_prop_i(2,5,8,'AllowNulls',n).
tbl_att_prop_i(1,5,8,'AllowNulls',n).
tbl_att_prop_i(2,'GXA0005','T.CarreraId','AllowNulls',n).
tbl_att_prop_i(1,7,17,'AllowNulls',n).
tbl_att_prop_i(1,7,17,'AUTONUMBER',y).
tbl_att_prop_i(1,7,26,'AllowNulls',n).
tbl_att_prop_i(1,7,22,'AllowNulls',n).
tbl_att_prop_i(1,7,24,'AllowNulls',n).
tbl_att_prop_i(2,7,17,'AllowNulls',n).
tbl_att_prop_i(2,7,26,'AllowNulls',n).
tbl_att_prop_i(2,7,22,'AllowNulls',n).
tbl_att_prop_i(2,7,24,'AllowNulls',n).
 
 
 
 
 
 
attri_i(40000,[ 'EstudianteFoto_GXI',svchar,2048,0,'',0,'',[],0 ]).
 
 
 
insert_w_subselect_i(7).
insert_w_subselect_i(5).
 
 
 
 
 
 
 
is_dynamic_trn_i(1,9,no).
is_dynamic_trn_i(1,7,no).
is_dynamic_trn_i(1,8,no).
is_dynamic_trn_i(2,7,no).
is_dynamic_trn_i(1,6,no).
is_dynamic_trn_i(1,5,no).
is_dynamic_trn_i(1,2,no).
is_dynamic_trn_i(2,5,no).
 
 
add_att_i(bits,1,40000,19,'EstudianteFoto_GXI',[ svchar,2048,0,0 ]).
add_att_i(bits,2,40000,19,'EstudianteFoto_GXI',[ svchar,2048,0,0 ]).
add_att_i(bits,2,'T.EstudianteFoto_GXI','T.EstudianteFoto','T.EstudianteFoto_GXI',[ svchar,2048,0,0 ]).
 
 
 
 
