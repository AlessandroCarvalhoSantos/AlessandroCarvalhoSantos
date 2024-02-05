import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MeuPrimeitoComponenteComponent } from './meu-primeito-componente/meu-primeito-componente.component';

import { CursosModule } from "./cursos/cursos.module"
import { CursosComponent } from "./cursos/cursos.component"

@NgModule({
  declarations: [
    AppComponent,
    MeuPrimeitoComponenteComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    CursosModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
