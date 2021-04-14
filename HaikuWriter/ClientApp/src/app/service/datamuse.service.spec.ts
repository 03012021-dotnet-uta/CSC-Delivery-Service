import { TestBed, inject } from '@angular/core/testing';
import { HttpClient, HttpEvent, HttpEventType } from '@angular/common/http';
import {
  HttpClientTestingModule,
  HttpTestingController
} from '@angular/common/http/testing';
import { DatamuseService } from './datamuse.service';

describe('DatamuseService', () => {
    let service: DatamuseService;
    let words: any;
    let httpMock: HttpTestingController;
    let httpClient: HttpClient;

  beforeEach(() => {
    TestBed.configureTestingModule({
      imports: [HttpClientTestingModule],
      providers: [DatamuseService]
    });
    service = TestBed.inject(DatamuseService);
    httpMock = TestBed.get(HttpTestingController);
    httpClient = TestBed.inject(HttpClient);
  });

  it('should be created', () => {
      expect(service).toBeTruthy();
  });

  it('getdata() should get words from url', async() => {
    let url = 'https://api.datamuse.com/words?rel_syn=ocean';
    words = {word: "sea", score: 4730};
    service.getData(url).subscribe((word) => {
        expect(word).toEqual(words);
    });

    const req = httpMock.expectOne(url);

    httpMock.verify();
  })
});