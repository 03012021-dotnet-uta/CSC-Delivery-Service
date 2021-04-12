import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HaikuDetailsComponent } from './haiku-details.component';

describe('HaikuDetailsComponent', () => {
  let component: HaikuDetailsComponent;
  let fixture: ComponentFixture<HaikuDetailsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HaikuDetailsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(HaikuDetailsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
