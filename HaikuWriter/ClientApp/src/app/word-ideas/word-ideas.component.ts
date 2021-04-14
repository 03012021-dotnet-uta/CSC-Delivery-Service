import { Component, OnInit } from '@angular/core';
import { DatamuseService} from '../service/datamuse.service';

@Component({
  selector: 'app-word-ideas',
  templateUrl: './word-ideas.component.html',
  styleUrls: ['./word-ideas.component.css']
})
export class WordIdeasComponent implements OnInit {
  words: any;

  constructor(private datamuseService: DatamuseService) { }

  getSyn():void{  
    //get user input
    let userWord = (<HTMLInputElement>document.getElementById("userInput")).value
    let url = 'https://api.datamuse.com/words?rel_syn=' + userWord;
    console.log(url)
    this.datamuseService.getData(url).subscribe(data=>
      {
        this.words=data;
        console.log(this.words);
      })
  }

  getRhy(): void{
    //get user input
    let userWord = (<HTMLInputElement>document.getElementById("userInput")).value
    let url = 'https://api.datamuse.com/words?rel_rhy=' + userWord;
    console.log(url)
    this.datamuseService.getData(url).subscribe(data=>
      {
        this.words=data;
        console.log(this.words);
      })
  }

  getAnt(): void{
    //get user input
    let userWord = (<HTMLInputElement>document.getElementById("userInput")).value
    let url = 'https://api.datamuse.com/words?rel_ant=' + userWord;
    console.log(url)
    this.datamuseService.getData(url).subscribe(data=>
      {
        this.words=data;
        console.log(this.words);
      })
  }

  getSoundsLike(): void {
    //get user input
    let userWord = (<HTMLInputElement>document.getElementById("userInput")).value
    let url = 'https://api.datamuse.com/words?sl=' + userWord;
    console.log(url)
    this.datamuseService.getData(url).subscribe(data=>
      {
        this.words=data;
        console.log(this.words);
    })
  }

  ngOnInit(): void {
  
  }

}
