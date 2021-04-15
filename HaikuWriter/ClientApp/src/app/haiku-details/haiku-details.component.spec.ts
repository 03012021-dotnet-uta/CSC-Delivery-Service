import { ComponentFixture, TestBed } from '@angular/core/testing';
import { RouterTestingModule } from '@angular/router/testing';
import {HttpClientModule} from '@angular/common/http';
import { HaikuDetailsComponent } from './haiku-details.component';
import { FormsModule, NgForm } from '@angular/forms';

describe('HaikuDetailsComponent', () => {
  let component: HaikuDetailsComponent;
  let fixture: ComponentFixture<HaikuDetailsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [RouterTestingModule, HttpClientModule, FormsModule],
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

  it("submithiuku Should be truthy", () =>{
      expect(component.SubmitHaiku()).toBeTruthy
  })

  it("User admin status should be false", () =>{
      expect(component.user.adminStatus).toBeFalsy;
  })

});
