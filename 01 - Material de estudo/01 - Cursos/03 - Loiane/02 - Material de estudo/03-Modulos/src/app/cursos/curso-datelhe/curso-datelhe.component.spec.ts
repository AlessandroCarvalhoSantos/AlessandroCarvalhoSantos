import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CursoDatelheComponent } from './curso-datelhe.component';

describe('CursoDatelheComponent', () => {
  let component: CursoDatelheComponent;
  let fixture: ComponentFixture<CursoDatelheComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [CursoDatelheComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(CursoDatelheComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
