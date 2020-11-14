import { Component, OnInit } from '@angular/core';
import { IEducation } from './education';
import { dataService } from '../shared/data.service';

@Component({
  selector: 'app-education',
  templateUrl: './education.component.html',
  styleUrls: ['./education.component.css']
})
export class EducationComponent implements OnInit {
  constructor(private EducationService: dataService) { }
  errorMessage: string;
  Education: IEducation[] = [];
  ngOnInit(): void {
     this.EducationService.getEducation().subscribe({
       next: education => this.Education = education,
       error: err => this.errorMessage =  err
     });
  }
}
