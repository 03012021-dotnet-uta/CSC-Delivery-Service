import { ComponentFixture, TestBed } from '@angular/core/testing';
import { RouterTestingModule } from '@angular/router/testing';
import {HttpClientModule} from '@angular/common/http';
import { AdminComponent } from './admin.component';

<<<<<<< HEAD

describe('AdminComponent', () => {
  let component: AdminComponent;
  let fixture: ComponentFixture<AdminComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [RouterTestingModule, HttpClientModule],
      declarations: [ AdminComponent ]
      
    })
    .compileComponents();
  });
=======
// describe('AdminComponent', () => {
//   let component: AdminComponent;
//   let fixture: ComponentFixture<AdminComponent>;

//   beforeEach(async () => {
//     await TestBed.configureTestingModule({
//       declarations: [ AdminComponent ]
//     })
//     .compileComponents();
//   });
>>>>>>> 6c43d8777772e6bdf7f9a116b72e86faf852f59c

//   beforeEach(() => {
//     fixture = TestBed.createComponent(AdminComponent);
//     component = fixture.componentInstance;
//     fixture.detectChanges();
//   });

//   it('should create', () => {
//     expect(component).toBeTruthy();
//   });
// });
