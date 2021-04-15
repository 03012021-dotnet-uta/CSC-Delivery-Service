import { ComponentFixture, TestBed } from '@angular/core/testing';
import { RouterTestingModule } from '@angular/router/testing';
import {HttpClientModule} from '@angular/common/http';
import { ThreadListComponent } from './thread-list.component';
import {FormsModule} from '@angular/forms';
describe('ThreadListComponent', () => {
  let component: ThreadListComponent;
  let fixture: ComponentFixture<ThreadListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
        imports: [RouterTestingModule, HttpClientModule, FormsModule],
      declarations: [ ThreadListComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ThreadListComponent);
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
