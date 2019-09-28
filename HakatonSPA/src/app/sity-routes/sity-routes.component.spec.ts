import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SityRoutesComponent } from './sity-routes.component';

describe('SityRoutesComponent', () => {
  let component: SityRoutesComponent;
  let fixture: ComponentFixture<SityRoutesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SityRoutesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SityRoutesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
