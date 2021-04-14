import { ComponentFixture, TestBed, async, inject } from '@angular/core/testing';
import { WordIdeasComponent } from './word-ideas.component';
import { RouterTestingModule } from '@angular/router/testing';
import { HttpClientTestingModule } from '@angular/common/http/testing';
import { HttpClient, HttpEvent, HttpEventType } from '@angular/common/http';
import {HttpTestingController} from '@angular/common/http/testing';
import { DatamuseService } from '../service/datamuse.service';

describe('WordIdeasComponent', () => {
    let component: WordIdeasComponent;
    let fixture: ComponentFixture<WordIdeasComponent>;
    let words: any;
    let httpMock: HttpTestingController;
    let httpClient: HttpClient;
    let service: DatamuseService;

    beforeEach(async(() => {
      TestBed.configureTestingModule({
        imports: [
            RouterTestingModule,
            HttpClientTestingModule
        ],
        providers: [DatamuseService],
        declarations: [
            WordIdeasComponent
        ],
      }).compileComponents();
        service = TestBed.inject(DatamuseService);
        httpMock = TestBed.get(HttpTestingController);
        httpClient = TestBed.inject(HttpClient);
    }));

    beforeEach(() => {
        fixture = TestBed.createComponent(WordIdeasComponent);
    });

    it("should create", () => {
        expect(component).toBeTruthy;
    });

  });

  