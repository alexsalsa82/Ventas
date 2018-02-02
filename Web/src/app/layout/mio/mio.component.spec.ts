import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MioComponent } from './mio.component';

describe('MioComponent', () => {
  let component: MioComponent;
  let fixture: ComponentFixture<MioComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MioComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MioComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
