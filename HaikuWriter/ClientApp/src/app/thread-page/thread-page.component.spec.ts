import { ComponentFixture, TestBed } from '@angular/core/testing';
import { RouterTestingModule } from '@angular/router/testing';
import {HttpClientModule} from '@angular/common/http';
import { FormsModule, NgForm } from '@angular/forms';


import { ThreadPageComponent } from './thread-page.component';

describe('ThreadPageComponent', () => {
  let component: ThreadPageComponent;
  let fixture: ComponentFixture<ThreadPageComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
        imports: [RouterTestingModule, HttpClientModule, FormsModule],
      declarations: [ ThreadPageComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ThreadPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();

  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

  it('onNext Should increment x ', () =>{
      component.onNext()
      fixture.detectChanges();
      expect(component.x).toEqual(1)
  })
  it('onNext Should increment x ', () =>{

    component.onPrev()
    fixture.detectChanges();
    expect(component.x).toEqual(-1)
})

});
