import { Component } from '@angular/core';

import { CursosService } from "./cursos.service";

@Component({
  selector: 'app-cursos',
  templateUrl: './cursos.component.html',
  styleUrl: './cursos.component.css'
})
export class CursosComponent {
  link:string = "Link.com.br";

  cursos: string[];
  
  constructor(public cursosService: CursosService){
    this.cursos = cursosService.getCursos()
  }
}
