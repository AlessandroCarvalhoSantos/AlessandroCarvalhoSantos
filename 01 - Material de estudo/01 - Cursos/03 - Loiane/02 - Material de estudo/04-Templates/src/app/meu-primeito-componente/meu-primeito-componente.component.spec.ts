import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MeuPrimeitoComponenteComponent } from './meu-primeito-componente.component';

describe('MeuPrimeitoComponenteComponent', () => {
  let component: MeuPrimeitoComponenteComponent;
  let fixture: ComponentFixture<MeuPrimeitoComponenteComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [MeuPrimeitoComponenteComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(MeuPrimeitoComponenteComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
