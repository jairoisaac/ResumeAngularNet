import { Component, OnInit } from '@angular/core';
import { dataService } from '../shared/data.service';
import { IExperience } from './experience';

@Component({
  selector: 'app-experience',
  templateUrl: './experience.component.html',
  styleUrls: ['./experience.component.css']
})
export class ExperienceComponent implements OnInit {
  constructor(private ExperienceService: dataService) { }
  errorMessage: string;
  Experience: IExperience[] = [];
  ngOnInit(): void {
      this.ExperienceService.getExperience().subscribe({
        next: experience => this.Experience = experience,
        error: err => this.errorMessage = err
      });
  }
}
