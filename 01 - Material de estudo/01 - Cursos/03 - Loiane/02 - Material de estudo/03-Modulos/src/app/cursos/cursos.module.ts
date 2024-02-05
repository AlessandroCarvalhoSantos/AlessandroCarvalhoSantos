import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { CursosComponent } from '../cursos/cursos.component';
import { CursoDatelheComponent } from './curso-datelhe/curso-datelhe.component';


@NgModule({
  declarations: [
    CursosComponent,
    CursoDatelheComponent
  ],
  imports: [
    CommonModule
  ],
  exports:[
    CursosComponent
  ]
})
export class CursosModule { }
