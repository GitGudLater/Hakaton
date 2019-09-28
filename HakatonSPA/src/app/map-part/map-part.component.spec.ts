import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MapPartComponent } from './map-part.component';

describe('MapPartComponent', () => {
  let component: MapPartComponent;
  let fixture: ComponentFixture<MapPartComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MapPartComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MapPartComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
